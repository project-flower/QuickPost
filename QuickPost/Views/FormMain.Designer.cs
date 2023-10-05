namespace QuickPost.Views
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            toolStripMenuItemFile = new ToolStripMenuItem();
            toolStripMenuItemNew = new ToolStripMenuItem();
            toolStripMenuItemLoad = new ToolStripMenuItem();
            toolStripMenuItemSave = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemQuit1 = new ToolStripMenuItem();
            toolStripMenuItemHelp = new ToolStripMenuItem();
            toolStripMenuItemVersionInfo = new ToolStripMenuItem();
            contextMenuStrip = new ContextMenuStrip(components);
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemSettings = new ToolStripMenuItem();
            toolStripMenuItemQuit2 = new ToolStripMenuItem();
            notifyIcon = new NotifyIcon(components);
            tabControl = new TabControl();
            tabPageMain = new TabPage();
            mainView = new MainView();
            tabPageTokens = new TabPage();
            credentialManageViewTokens = new CredentialManageView();
            tabPageWebhooks = new TabPage();
            credentialManageViewWebhooks = new CredentialManageView();
            tabPageSettings = new TabPage();
            settingView = new SettingView();
            buttonApply = new Button();
            buttonMinimize = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageMain.SuspendLayout();
            tabPageTokens.SuspendLayout();
            tabPageWebhooks.SuspendLayout();
            tabPageSettings.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.System;
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 4;
            // 
            // toolStripMenuItemFile
            // 
            toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNew, toolStripMenuItemLoad, toolStripMenuItemSave, toolStripSeparator1, toolStripMenuItemQuit1 });
            toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            toolStripMenuItemFile.Size = new Size(67, 20);
            toolStripMenuItemFile.Text = "ファイル(&F)";
            // 
            // toolStripMenuItemNew
            // 
            toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            toolStripMenuItemNew.ShortcutKeys = Keys.Control | Keys.N;
            toolStripMenuItemNew.Size = new Size(203, 22);
            toolStripMenuItemNew.Text = "新規(&N)";
            toolStripMenuItemNew.Click += toolStripMenuItemNew_Click;
            // 
            // toolStripMenuItemLoad
            // 
            toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            toolStripMenuItemLoad.ShortcutKeys = Keys.Control | Keys.L;
            toolStripMenuItemLoad.Size = new Size(203, 22);
            toolStripMenuItemLoad.Text = "設定を読み込む";
            toolStripMenuItemLoad.Click += toolStripMenuItemOpen_Click;
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItemSave.Size = new Size(203, 22);
            toolStripMenuItemSave.Text = "設定を保存する(&S)";
            toolStripMenuItemSave.Click += toolStripMenuItemSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(200, 6);
            // 
            // toolStripMenuItemQuit1
            // 
            toolStripMenuItemQuit1.Name = "toolStripMenuItemQuit1";
            toolStripMenuItemQuit1.Size = new Size(203, 22);
            toolStripMenuItemQuit1.Text = "終了(&X)";
            toolStripMenuItemQuit1.Click += toolStripMenuItemQuit_Click;
            // 
            // toolStripMenuItemHelp
            // 
            toolStripMenuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemVersionInfo });
            toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            toolStripMenuItemHelp.Size = new Size(65, 20);
            toolStripMenuItemHelp.Text = "ヘルプ(&H)";
            // 
            // toolStripMenuItemVersionInfo
            // 
            toolStripMenuItemVersionInfo.Name = "toolStripMenuItemVersionInfo";
            toolStripMenuItemVersionInfo.Size = new Size(158, 22);
            toolStripMenuItemVersionInfo.Text = "バージョン情報(&A)";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, toolStripMenuItemSettings, toolStripMenuItemQuit2 });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip.Size = new Size(114, 54);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(110, 6);
            // 
            // toolStripMenuItemSettings
            // 
            toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            toolStripMenuItemSettings.Size = new Size(113, 22);
            toolStripMenuItemSettings.Text = "設定(&S)";
            toolStripMenuItemSettings.Click += toolStripMenuItemSettings_Click;
            // 
            // toolStripMenuItemQuit2
            // 
            toolStripMenuItemQuit2.Name = "toolStripMenuItemQuit2";
            toolStripMenuItemQuit2.Size = new Size(113, 22);
            toolStripMenuItemQuit2.Text = "終了(&X)";
            toolStripMenuItemQuit2.Click += toolStripMenuItemQuit_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "QuickPost";
            notifyIcon.Visible = true;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageMain);
            tabControl.Controls.Add(tabPageTokens);
            tabControl.Controls.Add(tabPageWebhooks);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Location = new Point(12, 27);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 382);
            tabControl.TabIndex = 1;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(mainView);
            tabPageMain.Location = new Point(4, 24);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(768, 354);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "メイン";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // mainView
            // 
            mainView.AutoSize = true;
            mainView.Dock = DockStyle.Fill;
            mainView.Location = new Point(3, 3);
            mainView.Name = "mainView";
            mainView.Size = new Size(762, 348);
            mainView.TabIndex = 0;
            mainView.AddClick += mainView_AddClick;
            mainView.DeleteClick += mainView_DeleteClick;
            mainView.EditClick += mainView_EditClick;
            // 
            // tabPageTokens
            // 
            tabPageTokens.Controls.Add(credentialManageViewTokens);
            tabPageTokens.Location = new Point(4, 24);
            tabPageTokens.Name = "tabPageTokens";
            tabPageTokens.Padding = new Padding(3);
            tabPageTokens.Size = new Size(768, 354);
            tabPageTokens.TabIndex = 1;
            tabPageTokens.Text = "トークン";
            tabPageTokens.UseVisualStyleBackColor = true;
            // 
            // credentialManageViewTokens
            // 
            credentialManageViewTokens.Dock = DockStyle.Fill;
            credentialManageViewTokens.Location = new Point(3, 3);
            credentialManageViewTokens.Name = "credentialManageViewTokens";
            credentialManageViewTokens.Size = new Size(762, 348);
            credentialManageViewTokens.TabIndex = 0;
            credentialManageViewTokens.AddClick += credentialManageViewTokens_CredentialManageViewAddClick;
            credentialManageViewTokens.DeleteClick += credentialManageViewTokens_CredentialManageViewDeleteClick;
            credentialManageViewTokens.EditClick += credentialManageViewTokens_EditClick;
            // 
            // tabPageWebhooks
            // 
            tabPageWebhooks.Controls.Add(credentialManageViewWebhooks);
            tabPageWebhooks.Location = new Point(4, 24);
            tabPageWebhooks.Name = "tabPageWebhooks";
            tabPageWebhooks.Size = new Size(768, 354);
            tabPageWebhooks.TabIndex = 2;
            tabPageWebhooks.Text = "Webhook";
            tabPageWebhooks.UseVisualStyleBackColor = true;
            // 
            // credentialManageViewWebhooks
            // 
            credentialManageViewWebhooks.Dock = DockStyle.Fill;
            credentialManageViewWebhooks.Location = new Point(0, 0);
            credentialManageViewWebhooks.Name = "credentialManageViewWebhooks";
            credentialManageViewWebhooks.Size = new Size(768, 354);
            credentialManageViewWebhooks.TabIndex = 0;
            credentialManageViewWebhooks.AddClick += credentialManageViewWebhooks_CredentialManageViewAddClick;
            credentialManageViewWebhooks.DeleteClick += credentialManageViewWebhooks_CredentialManageViewDeleteClick;
            credentialManageViewWebhooks.EditClick += credentialManageViewWebhooks_EditClick;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(settingView);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Size = new Size(768, 354);
            tabPageSettings.TabIndex = 3;
            tabPageSettings.Text = "設定";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // settingView
            // 
            settingView.BalloonTipTimeout = 0;
            settingView.Dock = DockStyle.Fill;
            settingView.Location = new Point(0, 0);
            settingView.Name = "settingView";
            settingView.Size = new Size(768, 354);
            settingView.TabIndex = 0;
            settingView.ApplyBalloonTipTimeoutClick += settingView_ApplyBalloonTipTimeoutClick;
            // 
            // buttonApply
            // 
            buttonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonApply.Location = new Point(632, 415);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(75, 23);
            buttonApply.TabIndex = 2;
            buttonApply.Text = "適用(&A)";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMinimize.Location = new Point(713, 415);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(75, 23);
            buttonMinimize.TabIndex = 3;
            buttonMinimize.Text = "最小化(&M)";
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "xml";
            openFileDialog.Filter = "XML ファイル|*.xml|すべてのファイル|*.*";
            openFileDialog.Title = "開く";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.FileName = "settings.xml";
            saveFileDialog.Filter = "XML ファイル|*.xml|すべてのファイル|*.*";
            saveFileDialog.Title = "名前を付けて保存";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonApply);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            Text = "QuickPost";
            FormClosing += formClosing;
            Shown += shown;
            VisibleChanged += visibleChanged;
            Resize += resize;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tabPageMain.PerformLayout();
            tabPageTokens.ResumeLayout(false);
            tabPageWebhooks.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemNew;
        private ToolStripMenuItem toolStripMenuItemLoad;
        private ToolStripMenuItem toolStripMenuItemSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemQuit1;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemVersionInfo;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemSettings;
        private ToolStripMenuItem toolStripMenuItemQuit2;
        private NotifyIcon notifyIcon;
        private TabControl tabControl;
        private TabPage tabPageMain;
        private TabPage tabPageTokens;
        private Button buttonApply;
        private Button buttonMinimize;
        private TabPage tabPageWebhooks;
        private TabPage tabPageSettings;
        private Views.MainView mainView;
        private Views.CredentialManageView credentialManageViewTokens;
        private Views.CredentialManageView credentialManageViewWebhooks;
        private Views.SettingView settingView;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}