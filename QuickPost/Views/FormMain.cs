using QuickPost.Common;
using QuickPost.Events;
using QuickPost.ExtensionMethods;
using QuickPost.Models;
using QuickPost.PInvokes;
using QuickPost.PInvokes.Public;
using QuickPost.Properties;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;

namespace QuickPost.Views
{
    public partial class FormMain : Form
    {
        #region Privte Fields

        private ushort balloonTipTimeout;
        private readonly FormEditPostItem formEditPostItem = new();
        private readonly FormEditCredential formEditToken = new() { Text = "トークン", NameOfValue = "トークン" };
        private readonly FormEditCredential formEditWebhook = new() { Text = "Webhook", NameOfValue = "Webhook URL" };
        private readonly Exception? initializationException;
        /// <summary>変更されたアプリケーション設定が保存されていない場合、true。</summary>
        private bool isDirty = false;
        private Font menuFont;
        private FormWindowState prevWindowState = FormWindowState.Normal;
        private readonly Settings settings = Settings.Default;
        private readonly MethodInfo? showContextMenuInTaskbar;

        #endregion

        #region Public Properties

        public bool MustBeShown { get; private set; }

        #endregion

        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            menuFont = contextMenuStripMain.Font;

            // Get protected methods
            showContextMenuInTaskbar = typeof(ContextMenuStrip).GetMethod("ShowInTaskbar", (BindingFlags.Instance | BindingFlags.NonPublic));

            // Set control properties
            notifyIcon.Icon = Icon;
            SetNotifyIconEventHandlers();

            // Load application settings
            try
            {
                if (!settings.Upgraded)
                {
                    settings.Upgrade();
                    settings.Upgraded = true;
                }

                LoadSettings(false);

                if (!settings.IsUserSettings)
                {
                    MustBeShown = true;
                }

                initializationException = null;
            }
            catch (Exception exception)
            {
                // Handle app.config, user.config exceptions
                initializationException = exception;
                MustBeShown = true;
            }
        }

        #endregion

        #region Private Methods

        private void AddCredential(string prefix, FormEditCredential form, string defaultValue, CredentialManageViewClickEventArgs eventArgs, CredentialManageView view)
        {
            form.ValueOfName = string.Empty;
            form.Value = defaultValue;
            string name;

            while (true)
            {
                if (form.ShowDialog(this, true) != DialogResult.OK) return;

                name = form.ValueOfName;

                if (view.Values.Any(n => string.Compare(n, name, true) == 0))
                {
                    this.ShowErrorMessage($"{name} は既に存在します。");
                    continue;
                }

                break;
            }

            string credName = $"{prefix}{name}";
            bool exists;

            try
            {
                exists = CredentialManager.Exists(credName);
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception);
                return;
            }

            if (exists && this.ShowMessage(
                $"{form.Text} {credName}\r\nは資格情報に存在します。上書きしますか？"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                Common.Credential credential = new(credName, "QuikPost", form.Value);
                CredentialManager.Write(credential);
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception);
                return;
            }

            eventArgs.Name = name;
            eventArgs.Accepted = true;
        }

        private void ApplyMenuItems()
        {
            while (contextMenuStripMain.Items[0] != toolStripSeparator2)
            {
                ToolStripItem item = contextMenuStripMain.Items[0];
                Image image = item.Image;
                item.Image = null;
                image?.Dispose();
                item.Click -= toolStripMenuItem_Click;
                contextMenuStripMain.Items.Remove(item);
            }

            int index = 0;

            foreach (PostItem postItem in mainView.Items)
            {
                ToolStripMenuItem item = new(postItem.Name) { Tag = postItem };

                try
                {
                    item.Font = menuFont;
                }
                catch
                {
                }

                try
                {
                    string imageFile = postItem.ImageFile;

                    if (File.Exists(imageFile))
                    {
                        item.Image = Image.FromFile(imageFile);
                    }
                }
                catch
                {
                }

                item.Click += toolStripMenuItem_Click;
                contextMenuStripMain.Items.Insert(index, item);
                ++index;
            }
        }

        private void ApplySettings()
        {
            balloonTipTimeout = settingView.BalloonTipTimeout;
            int height = settingView.MenuIconSize;
            contextMenuStripMain.ImageScalingSize = new Size(height, height);
            UpdateMenuFonts();
            SaveSettings(true);
        }

        private bool ConfirmApplicationQuit()
        {
            return (this.ShowMessage(
                "終了しますか？"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == DialogResult.Yes);
        }

        private void DeleteCredential(string prefix, CredentialManageViewClickEventArgs eventArgs)
        {
            string name = eventArgs.Name;

            if (this.ShowMessage(
                $"{name} を削除します。よろしいですか？"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) != DialogResult.Yes) return;

            if (string.IsNullOrEmpty(name))
            {
                eventArgs.Accepted = true;
                return;
            }

            try
            {
                CredentialManager.Delete($"{prefix}{name}");
            }
            catch (Win32Exception exception)
            {
                if (exception.NativeErrorCode != Win32Error.ERROR_NOT_FOUND)
                {
                    // ERROR_NOT_FOUND 以外
                    this.ShowErrorMessage(exception);
                }

                eventArgs.Accepted = true;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception);
                return;
            }
        }

        private void EditCredential(string prefix, FormEditCredential form, CredentialManageViewClickEventArgs eventArgs)
        {
            form.ValueOfName = eventArgs.Name;
            form.Value = string.Empty;

            if (form.ShowDialog(this, false) != DialogResult.OK) return;

            string name = form.ValueOfName;
            string credName = $"{prefix}{name}";

            try
            {
                Credential credential = new(credName, "QuikPost", form.Value);
                CredentialManager.Write(credential);
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception);
                return;
            }

            eventArgs.Name = name;
            eventArgs.Accepted = true;
        }

        private void Initialize()
        {
            mainView.Initialize();
            credentialManageViewTokens.Initialize();
            credentialManageViewWebhooks.Initialize();

            try
            {
                settings.Reset();
                isDirty = false;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception);
            }
        }

        private bool IsDirty()
        {
            return
                (mainView.IsDirty
                || credentialManageViewTokens.IsDirty
                || credentialManageViewWebhooks.IsDirty
                || settingView.IsDirty
                || isDirty);
        }

        private void LoadSettings(bool loadFile)
        {
            try
            {
                if (loadFile) settings.Reload();

                WebEngine.Initialize(settings.ChatPostMessageEndpoint, settings.CredTokenPrefix, settings.CredWebhookPrefix);
                balloonTipTimeout = settings.BalloonTipTimeout;
                menuFont = settings.MenuFont;
                int height = settings.MenuIconSize;
                contextMenuStripMain.ImageScalingSize = new Size(height, height);
                credentialManageViewTokens.Values = ToEnumerable(settings.ChatPostTokens);
                credentialManageViewWebhooks.Values = ToEnumerable(settings.WebhookUrls);
                StringCollection postItems = settings.PostItems;

                if (postItems != null)
                {
                    mainView.Items = postItems.OfType<string>().Select(n => JsonSerializer.Deserialize<PostItem>(n)!);
                }
                else
                {
                    mainView.Initialize();
                }

                ApplyMenuItems();
                RestoreDirty();
            }
            catch
            {
                throw;
            }
        }

        private void notifyIcon_MouseClick(object? sender, MouseEventArgs e)
        {
            ContextMenuStrip contextMenuStrip =
                ((e.Button == MouseButtons.Left) ? contextMenuStripMain : contextMenuStripSystem);

            if (!contextMenuStrip.Visible)
            {
                // Suppress display of task tray icon
                WindowManager.SetForegroundWindow(contextMenuStrip.Handle);

                if (showContextMenuInTaskbar != null)
                {
                    Point position = Cursor.Position;
                    showContextMenuInTaskbar.Invoke(contextMenuStrip, new object[] { position.X, position.Y });
                }
                else
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void PostMessage(PostItem postItem)
        {
            Exception? exception = null;

            try
            {
                WebEngine.Post(postItem);
            }
            catch (Exception exception_)
            {
                exception = exception_;
            }

            if (balloonTipTimeout < 1) return;

            string message;
            ToolTipIcon icon;

            if (exception == null)
            {
                message = $"投稿しました。\r\n\r\n{postItem.Name}";
                icon = ToolTipIcon.Info;
            }
            else
            {
                message = $"投稿に失敗しました。\r\n\r\nエラー:\r\n{exception.Message}";
                icon = ToolTipIcon.Error;
            }

            notifyIcon.ShowBalloonTip(balloonTipTimeout, Text, message, icon);
        }

        private void RestoreDirty()
        {
            mainView.IsDirty = false;
            credentialManageViewTokens.IsDirty = false;
            credentialManageViewWebhooks.IsDirty = false;
            settingView.IsDirty = false;
            isDirty = false;
        }

        private void RestoreWindow()
        {
            if (!Visible) Show();

            if (WindowState != prevWindowState)
            {
                WindowState = prevWindowState;
            }

            BringToFront();
        }

        private bool SaveSettings(bool showInformation)
        {
            try
            {
                settings.ChatPostTokens = ToStringCollection(credentialManageViewTokens.Values);
                settings.WebhookUrls = ToStringCollection(credentialManageViewWebhooks.Values);
                settings.MenuFont = menuFont;
                settings.BalloonTipTimeout = balloonTipTimeout;
                settings.MenuIconSize = (ushort)contextMenuStripMain.ImageScalingSize.Height;
                settings.IsUserSettings = true;
                StringCollection postItems = new();
                postItems.Clear();

                foreach (PostItem postItem in mainView.Items) postItems.Add(JsonSerializer.Serialize(postItem));

                settings.PostItems = postItems;
                settings.Save();
                RestoreDirty();

                if (showInformation) this.ShowInformation("設定を保存しました。");

                return true;
            }
            catch (Exception exception)
            {
                if (showInformation) this.ShowErrorMessage(exception);

                return false;
            }
        }

        private void SetNotifyIconEventHandlers()
        {
            if (Visible)
            {
                notifyIcon.MouseClick -= notifyIcon_MouseClick;
            }
            else
            {
                notifyIcon.MouseClick += notifyIcon_MouseClick;
            }
        }

        private static IEnumerable<string> ToEnumerable(StringCollection collection)
        {
            if (collection == null)
            {
                return Array.Empty<string>();
            }

            return collection.OfType<string>();
        }

        private static StringCollection ToStringCollection(IEnumerable<string> values)
        {
            StringCollection result = new();

            if (values != null)
            {
                foreach (string value in values) result.Add(value);
            }

            return result;
        }

        private void toolStripMenuItem_Click(object? sender, EventArgs e)
        {
            PostMessage((PostItem)((ToolStripMenuItem)sender!).Tag);
        }

        private void UpdateMenuFonts()
        {
            menuFont = settingView.MenuFont;

            foreach (ToolStripItem item in contextMenuStripMain.Items)
            {
                if (item == toolStripSeparator2) break;

                try
                {
                    item.Font = menuFont;
                }
                catch
                {
                }
            }
        }

        #endregion

        // Designer's Methods

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ApplyMenuItems();
            ApplySettings();
            Hide();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void credentialManageViewTokens_CredentialManageViewAddClick(object sender, CredentialManageViewClickEventArgs e)
        {
            AddCredential(settings.CredTokenPrefix, formEditToken, string.Empty, e, credentialManageViewTokens);
        }

        private void credentialManageViewTokens_CredentialManageViewDeleteClick(object sender, CredentialManageViewClickEventArgs e)
        {
            DeleteCredential(settings.CredTokenPrefix, e);
        }

        private void credentialManageViewTokens_EditClick(object sender, CredentialManageViewClickEventArgs e)
        {
            EditCredential(settings.CredTokenPrefix, formEditToken, e);
        }

        private void credentialManageViewWebhooks_CredentialManageViewAddClick(object sender, CredentialManageViewClickEventArgs e)
        {
            AddCredential(settings.CredWebhookPrefix, formEditWebhook, settings.IncomingWebhookRoot, e, credentialManageViewWebhooks);
        }

        private void credentialManageViewWebhooks_CredentialManageViewDeleteClick(object sender, CredentialManageViewClickEventArgs e)
        {
            DeleteCredential(settings.CredWebhookPrefix, e);
        }

        private void credentialManageViewWebhooks_EditClick(object sender, CredentialManageViewClickEventArgs e)
        {
            EditCredential(settings.CredWebhookPrefix, formEditWebhook, e);
        }

        /// <summary>
        /// <para>一度も表示 (Form.Show()) されないと FormClosing イベントは呼び出されない。</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (initializationException != null) return;

            if (!IsDirty()) return;

            if (this.ShowMessage(
                "ユーザー設定が変更されています。\r\nユーザー設定ファイルを保存しますか？"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            if (SaveSettings(true)) return;

            if (e.CloseReason != CloseReason.UserClosing) return;

            e.Cancel = !ConfirmApplicationQuit();
        }

        private void mainView_AddClick(object sender, MainViewClickEventArgs e)
        {
            formEditPostItem.Initialize(credentialManageViewTokens.Values, credentialManageViewWebhooks.Values);

            if (formEditPostItem.ShowDialog(this) != DialogResult.OK) return;

            e.Item = formEditPostItem.Value;
            e.Accepted = true;
        }

        private void mainView_DeleteClick(object sender, MainViewClickEventArgs e)
        {
            if (this.ShowMessage(
                $"{e.Item!.Name} を削除してもよいですか？"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) != DialogResult.Yes) return;

            e.Accepted = true;
        }

        private void mainView_EditClick(object sender, MainViewClickEventArgs e)
        {
            formEditPostItem.Initialize(credentialManageViewTokens.Values, credentialManageViewWebhooks.Values);
            formEditPostItem.Value = e.Item!;

            if (formEditPostItem.ShowDialog(this) != DialogResult.OK) return;

            e.Item = formEditPostItem.Value;
            e.Accepted = true;
        }

        private void resize(object sender, EventArgs e)
        {
            FormWindowState windowState = WindowState;

            if (windowState == FormWindowState.Minimized)
            {
                Hide();
            }
            else
            {
                prevWindowState = windowState;
            }
        }

        private void settingView_ButtonSelectFontClick(object sender, EventArgs e)
        {
            fontDialog.Font = settingView.MenuFont;

            if (fontDialog.ShowDialog() != DialogResult.OK) return;

            settingView.MenuFont = fontDialog.Font;
            settingView.IsDirty = true;
        }

        private void shown(object sender, EventArgs e)
        {
            if (initializationException == null) return;

            this.ShowErrorMessage(initializationException);
            // Form.Disposed event does not fire when closed in Form.Load event handler
            Close();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            if (this.ShowMessage(
                "設定ファイルを初期状態に戻します。\r\nよろしいですか？"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) != DialogResult.Yes) return;

            Initialize();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            if (IsDirty() && this.ShowMessage("設定が保存されていません。\r\n設定ファイルを読み込んでもよいですか？"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                LoadSettings(true);
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception);
                return;
            }
        }

        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            SaveSettings(true);
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            RestoreWindow();
        }

        private void visibleChanged(object sender, EventArgs e)
        {
            SetNotifyIconEventHandlers();
        }
    }
}
