namespace QuickPost.Views
{
    partial class FormEditPostItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            labelIcon = new Label();
            textBoxIconFile = new TextBox();
            buttonBrowseIcon = new Button();
            tabControl = new TabControl();
            tabPageChatPostMessage = new TabPage();
            textBoxText = new TextBox();
            labelText = new Label();
            textBoxChannel = new TextBox();
            labelChannel = new Label();
            comboBoxTokens = new ComboBox();
            labelToken = new Label();
            tabPageIncomingWebhook = new TabPage();
            textBoxPayload = new TextBox();
            labelPayload = new Label();
            comboBoxUrls = new ComboBox();
            labelUrl = new Label();
            buttonTest = new Button();
            buttonOk = new Button();
            buttonCancel = new Button();
            openFileDialogIcon = new OpenFileDialog();
            tabControl.SuspendLayout();
            tabPageChatPostMessage.SuspendLayout();
            tabPageIncomingWebhook.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(51, 15);
            labelName.TabIndex = 0;
            labelName.Text = "名前(&N):";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(74, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(514, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelIcon
            // 
            labelIcon.AutoSize = true;
            labelIcon.Location = new Point(12, 45);
            labelIcon.Name = "labelIcon";
            labelIcon.Size = new Size(56, 15);
            labelIcon.TabIndex = 2;
            labelIcon.Text = "アイコン(&I):";
            // 
            // textBoxIconFile
            // 
            textBoxIconFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIconFile.Location = new Point(74, 42);
            textBoxIconFile.Name = "textBoxIconFile";
            textBoxIconFile.Size = new Size(433, 23);
            textBoxIconFile.TabIndex = 3;
            // 
            // buttonBrowseIcon
            // 
            buttonBrowseIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBrowseIcon.Location = new Point(513, 41);
            buttonBrowseIcon.Name = "buttonBrowseIcon";
            buttonBrowseIcon.Size = new Size(75, 23);
            buttonBrowseIcon.TabIndex = 4;
            buttonBrowseIcon.Text = "参照";
            buttonBrowseIcon.UseVisualStyleBackColor = true;
            buttonBrowseIcon.Click += buttonBrowseIcon_Click;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageChatPostMessage);
            tabControl.Controls.Add(tabPageIncomingWebhook);
            tabControl.Location = new Point(12, 71);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(576, 238);
            tabControl.TabIndex = 3;
            // 
            // tabPageChatPostMessage
            // 
            tabPageChatPostMessage.Controls.Add(textBoxText);
            tabPageChatPostMessage.Controls.Add(labelText);
            tabPageChatPostMessage.Controls.Add(textBoxChannel);
            tabPageChatPostMessage.Controls.Add(labelChannel);
            tabPageChatPostMessage.Controls.Add(comboBoxTokens);
            tabPageChatPostMessage.Controls.Add(labelToken);
            tabPageChatPostMessage.Location = new Point(4, 24);
            tabPageChatPostMessage.Name = "tabPageChatPostMessage";
            tabPageChatPostMessage.Padding = new Padding(3);
            tabPageChatPostMessage.Size = new Size(568, 210);
            tabPageChatPostMessage.TabIndex = 0;
            tabPageChatPostMessage.Text = "Chat PostMessage";
            tabPageChatPostMessage.UseVisualStyleBackColor = true;
            // 
            // textBoxText
            // 
            textBoxText.AcceptsReturn = true;
            textBoxText.AcceptsTab = true;
            textBoxText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxText.Font = new Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxText.Location = new Point(83, 64);
            textBoxText.MaxLength = 0;
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.ScrollBars = ScrollBars.Both;
            textBoxText.Size = new Size(479, 140);
            textBoxText.TabIndex = 5;
            textBoxText.WordWrap = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(6, 67);
            labelText.Name = "labelText";
            labelText.Size = new Size(59, 15);
            labelText.TabIndex = 4;
            labelText.Text = "テキスト(&T):";
            // 
            // textBoxChannel
            // 
            textBoxChannel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxChannel.Location = new Point(83, 35);
            textBoxChannel.Name = "textBoxChannel";
            textBoxChannel.Size = new Size(479, 23);
            textBoxChannel.TabIndex = 3;
            // 
            // labelChannel
            // 
            labelChannel.AutoSize = true;
            labelChannel.Location = new Point(6, 38);
            labelChannel.Name = "labelChannel";
            labelChannel.Size = new Size(71, 15);
            labelChannel.TabIndex = 2;
            labelChannel.Text = "チャンネル(&C):";
            // 
            // comboBoxTokens
            // 
            comboBoxTokens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTokens.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTokens.FormattingEnabled = true;
            comboBoxTokens.Location = new Point(83, 6);
            comboBoxTokens.Name = "comboBoxTokens";
            comboBoxTokens.Size = new Size(479, 23);
            comboBoxTokens.TabIndex = 1;
            // 
            // labelToken
            // 
            labelToken.AutoSize = true;
            labelToken.Location = new Point(6, 9);
            labelToken.Name = "labelToken";
            labelToken.Size = new Size(58, 15);
            labelToken.TabIndex = 0;
            labelToken.Text = "トークン(&T):";
            // 
            // tabPageIncomingWebhook
            // 
            tabPageIncomingWebhook.Controls.Add(textBoxPayload);
            tabPageIncomingWebhook.Controls.Add(labelPayload);
            tabPageIncomingWebhook.Controls.Add(comboBoxUrls);
            tabPageIncomingWebhook.Controls.Add(labelUrl);
            tabPageIncomingWebhook.Location = new Point(4, 24);
            tabPageIncomingWebhook.Name = "tabPageIncomingWebhook";
            tabPageIncomingWebhook.Padding = new Padding(3);
            tabPageIncomingWebhook.Size = new Size(568, 210);
            tabPageIncomingWebhook.TabIndex = 1;
            tabPageIncomingWebhook.Text = "Incoming Webhook";
            tabPageIncomingWebhook.UseVisualStyleBackColor = true;
            // 
            // textBoxPayload
            // 
            textBoxPayload.AcceptsReturn = true;
            textBoxPayload.AcceptsTab = true;
            textBoxPayload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPayload.Font = new Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPayload.Location = new Point(81, 35);
            textBoxPayload.Multiline = true;
            textBoxPayload.Name = "textBoxPayload";
            textBoxPayload.ScrollBars = ScrollBars.Both;
            textBoxPayload.Size = new Size(481, 169);
            textBoxPayload.TabIndex = 3;
            textBoxPayload.WordWrap = false;
            // 
            // labelPayload
            // 
            labelPayload.AutoSize = true;
            labelPayload.Location = new Point(6, 38);
            labelPayload.Name = "labelPayload";
            labelPayload.Size = new Size(69, 15);
            labelPayload.TabIndex = 2;
            labelPayload.Text = "ペイロード(&P):";
            // 
            // comboBoxUrls
            // 
            comboBoxUrls.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxUrls.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUrls.FormattingEnabled = true;
            comboBoxUrls.Location = new Point(81, 6);
            comboBoxUrls.Name = "comboBoxUrls";
            comboBoxUrls.Size = new Size(681, 23);
            comboBoxUrls.TabIndex = 1;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Location = new Point(6, 9);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(31, 15);
            labelUrl.TabIndex = 0;
            labelUrl.Text = "&URL:";
            // 
            // buttonTest
            // 
            buttonTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTest.Location = new Point(351, 315);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(75, 23);
            buttonTest.TabIndex = 4;
            buttonTest.Text = "テスト(&T)";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Location = new Point(432, 315);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(513, 315);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // openFileDialogIcon
            // 
            openFileDialogIcon.Filter = "イメージ ファイル|*.bmp;*.dib;*.gif;*.jfif;*.jpe;*.jpeg;*.jpg;*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|PNG|*.png|ビットマップ ファイル|*.bmp;*.dib|GIF|*.gif|すべてのファイル|*.*";
            // 
            // FormEditPostItem
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(600, 350);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(buttonTest);
            Controls.Add(tabControl);
            Controls.Add(buttonBrowseIcon);
            Controls.Add(textBoxIconFile);
            Controls.Add(labelIcon);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            MinimizeBox = false;
            Name = "FormEditPostItem";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "投稿設定";
            tabControl.ResumeLayout(false);
            tabPageChatPostMessage.ResumeLayout(false);
            tabPageChatPostMessage.PerformLayout();
            tabPageIncomingWebhook.ResumeLayout(false);
            tabPageIncomingWebhook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelIcon;
        private TextBox textBoxIconFile;
        private Button buttonBrowseIcon;
        private TabControl tabControl;
        private TabPage tabPageChatPostMessage;
        private TabPage tabPageIncomingWebhook;
        private TextBox textBoxText;
        private Label labelText;
        private TextBox textBoxChannel;
        private Label labelChannel;
        private ComboBox comboBoxTokens;
        private Label labelToken;
        private Label labelUrl;
        private TextBox textBoxPayload;
        private Label labelPayload;
        private ComboBox comboBoxUrls;
        private Button buttonTest;
        private Button buttonOk;
        private Button buttonCancel;
        private OpenFileDialog openFileDialogIcon;
    }
}