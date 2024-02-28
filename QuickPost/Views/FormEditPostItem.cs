using QuickPost.ExtensionMethods;
using QuickPost.Models;

namespace QuickPost.Views
{
    public partial class FormEditPostItem : Form
    {
        #region Public Properties

        public PostItem Value
        {
            get
            {
                string name = textBoxName.Text;
                string iconFileName = textBoxIconFile.Text;

                if (tabControl.SelectedTab == tabPageChatPostMessage)
                {
                    return new ChatPostMessage()
                    {
                        Channel = textBoxChannel.Text,
                        ImageFile = iconFileName,
                        Name = name,
                        Text = textBoxText.Text,
                        TokenName = comboBoxTokens.Text
                    };
                }

                //if (tabControl.SelectedTab == tabPageIncomingWebhook)
                if (true)
                {
                    return new IncomingWebhook()
                    {
                        EndpointName = comboBoxUrls.Text,
                        ImageFile = iconFileName,
                        Name = name,
                        Payload = textBoxPayload.Text
                    };
                }
            }

            set
            {
                textBoxName.Text = value != null ? value.Name : string.Empty;
                textBoxIconFile.Text = value != null ? value.ImageFile : string.Empty;
                ResetComboBox(comboBoxTokens);
                textBoxChannel.Text = string.Empty;
                textBoxText.Text = string.Empty;
                ResetComboBox(comboBoxUrls);
                textBoxPayload.Text = string.Empty;

                if (value is ChatPostMessage chatPostMessage)
                {
                    tabControl.SelectTab(tabPageChatPostMessage);
                    comboBoxTokens.Text = chatPostMessage.TokenName;
                    textBoxChannel.Text = chatPostMessage.Channel;
                    textBoxText.Text = chatPostMessage.Text;
                }
                else if (value is IncomingWebhook incomingWebhook)
                {
                    tabControl.SelectTab(tabPageIncomingWebhook);
                    comboBoxUrls.Text = incomingWebhook.EndpointName;
                    textBoxPayload.Text = incomingWebhook.Payload;
                }
            }
        }

        #endregion

        #region Public Methods

        public FormEditPostItem()
        {
            InitializeComponent();
            MinimumSize = Size;
        }

        public void Initialize(IEnumerable<string> tokenNames, IEnumerable<string> webhookNames)
        {
            SetItems(comboBoxTokens, tokenNames);
            SetItems(comboBoxUrls, webhookNames);
            Clear();
        }

        #endregion

        #region Private Methods

        private void Clear()
        {
            textBoxName.Text = string.Empty;
            textBoxIconFile.Text = string.Empty;
            ResetComboBox(comboBoxTokens);
            textBoxChannel.Text = string.Empty;
            textBoxText.Text = string.Empty;
            ResetComboBox(comboBoxUrls);
            textBoxPayload.Text = string.Empty;
        }

        private static void ResetComboBox(ComboBox comboBox)
        {
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
            else
            {
                comboBox.Text = string.Empty;
            }
        }

        public static void SetItems(ComboBox comboBox, IEnumerable<string> values)
        {
            ComboBox.ObjectCollection items = comboBox.Items;
            comboBox.BeginUpdate();
            items.Clear();

            foreach (string item in values) items.Add(item);

            comboBox.EndUpdate();
        }

        #endregion

        // Designer's Methods

        private void buttonBrowseIcon_Click(object sender, EventArgs e)
        {
            string fileName = textBoxIconFile.Text;

            try
            {
                openFileDialogIcon.InitialDirectory = Path.GetDirectoryName(fileName);
                openFileDialogIcon.FileName = Path.GetFileName(fileName);
            }
            catch
            {
            }

            if (openFileDialogIcon.ShowDialog(this) != DialogResult.OK) return;

            textBoxIconFile.Text = openFileDialogIcon.FileName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text)
                || ((tabControl.SelectedTab == tabPageChatPostMessage)
                && (string.IsNullOrEmpty(comboBoxTokens.Text)
                || string.IsNullOrEmpty(textBoxChannel.Text)
                || string.IsNullOrEmpty(textBoxText.Text))
                || ((tabControl.SelectedTab == tabPageIncomingWebhook)
                && (string.IsNullOrEmpty(comboBoxUrls.Text)
                || string.IsNullOrEmpty(textBoxPayload.Text)))))
            {
                this.ShowErrorMessage("入力されていない項目があります。");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                WebEngine.Post(Value);
                this.ShowInformation("テスト投稿を実行しました。");
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage($"テスト投稿に失敗しました。\r\n\r\nエラー:\r\n{exception.Message}");
            }
        }
    }
}
