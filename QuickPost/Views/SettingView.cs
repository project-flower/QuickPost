using QuickPost.Events;
using QuickPost.Properties;
using System.Configuration;
using System.Diagnostics;

namespace QuickPost.Views
{
    /// <summary>
    /// このビューは設定を表示するだけで、読み込みや保存には関与しない。
    /// </summary>
    public partial class SettingView : UserControl
    {
        #region Private Fields

        private readonly Settings settings = Settings.Default;

        #endregion

        #region Public Properties

        public event RequireAcceptEventHandler ApplyBalloonTipTimeoutClick = delegate { };

        public int BalloonTipTimeout
        {
            get => (int)numericUpDownBalloonTipTimeout.Value;

            set
            {
                decimal maximum = numericUpDownBalloonTipTimeout.Maximum;
                decimal minimum = numericUpDownBalloonTipTimeout.Minimum;
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

                numericUpDownBalloonTipTimeout.Value = newValue;
            }
        }

        public bool IsDirty
        {
            get => isDirty;

            set
            {
                buttonApplyBalloonTipTimeout.Enabled = value;
                isDirty = value;
            }
        }

        #endregion

        #region Private Fields

        private bool isDirty = false;

        #endregion

        #region Public Methods

        public SettingView()
        {
            InitializeComponent();
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
                BalloonTipTimeout = settings.BalloonTipTimeout;
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

        private void buttonApplyBalloonTipTimeout_Click(object sender, EventArgs e)
        {
            RequireAcceptEventArgs args = new();
            ApplyBalloonTipTimeoutClick(this, args);
        }

        private void buttonReferSettingFile_Click(object sender, EventArgs e)
        {
            ShowInExplorer(textBoxSettingFileName.Text);
        }

        private void numericUpDownBalloonTipTimeout_ValueChanged(object sender, EventArgs e)
        {
            IsDirty = true;
        }
    }
}
