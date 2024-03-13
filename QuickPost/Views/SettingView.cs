using QuickPost.Events;
using QuickPost.Properties;
using System.Diagnostics;

namespace QuickPost.Views
{
    /// <summary>
    /// このビューは設定を表示するだけで、読み込みや保存には関与しない。
    /// </summary>
    public partial class SettingView : UserControl
    {
        #region Private Fields

        private bool isDirty = false;
        private Font menuFont;
        private readonly Settings settings = Settings.Default;

        #endregion

        #region Public Properties

        public event EventHandler ButtonSelectFontClick = delegate { };

        public ushort BalloonTipTimeout
        {
            get => (ushort)numericUpDownBalloonTipTimeout.Value;

            set { SetValue(numericUpDownBalloonTipTimeout, value); }
        }

        public bool IsDirty
        {
            get => isDirty;

            set
            {
                isDirty = value;
            }
        }

        public Font MenuFont
        {
            get => menuFont;

            set
            {
                menuFont = value;
                string fontName;

                if (menuFont == null)
                {
                    fontName = string.Empty;
                }
                else
                {
                    fontName = $"{menuFont.Name} {menuFont.SizeInPoints}pt.";
                }

                textBoxMenuFont.Text = fontName;
            }
        }

        public ushort MenuIconSize
        {
            get => (ushort)numericUpDownMenuIconSize.Value;

            set { SetValue(numericUpDownMenuIconSize, value); }
        }

        #endregion

        #region Public Methods

        public SettingView()
        {
            InitializeComponent();
            menuFont = Font;
            settings.SettingsLoaded += settings_SettingsLoaded;

            try
            {
                textBoxSettingFileName.Text = SettingManager.GetFilePath();
            }
            catch
            {
            }
        }

        #endregion

        #region Private Methods

        private void Apply()
        {
            try
            {
                MenuFont = settings.MenuFont;
                BalloonTipTimeout = settings.BalloonTipTimeout;
                MenuIconSize = settings.MenuIconSize;
                textBoxChatPostMessageEndpoint.Text = settings.ChatPostMessageEndpoint;
                textBoxIncomingWebhookRoot.Text = settings.IncomingWebhookRoot;
                textBoxCredTokenPrefix.Text = settings.CredTokenPrefix;
                textBoxCredWebhookPrefix.Text = settings.CredWebhookPrefix;
            }
            catch
            {
            }

            IsDirty = false;
        }

        private void settings_SettingsLoaded(object sender, System.Configuration.SettingsLoadedEventArgs e)
        {
            Apply();
        }

        private void SetValue(NumericUpDown numericUpDown, ushort value)
        {
            decimal maximum = numericUpDown.Maximum;
            decimal minimum = numericUpDown.Minimum;
            decimal newValue;

            if (value > maximum)
            {
                newValue = maximum;
            }
            else if (value < minimum)
            {
                newValue = minimum;
            }
            else
            {
                newValue = value;
            }

            numericUpDown.Value = newValue;
        }

        private static void ShowInExplorer(string fileName)
        {
            try
            {
                Process.Start("explorer.exe", $"/select,\"{fileName}\"");
            }
            catch
            {
            }
        }

        #endregion

        // Designer'd Methods

        private void buttonMenuFont_Click(object sender, EventArgs e)
        {
            ButtonSelectFontClick(this, new EventArgs());
        }

        private void buttonReferSettingFile_Click(object sender, EventArgs e)
        {
            ShowInExplorer(textBoxSettingFileName.Text);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            isDirty = true;
        }
    }
}
