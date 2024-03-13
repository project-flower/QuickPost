namespace QuickPost.Views
{
    partial class SettingView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            labelSettingFilePath = new Label();
            textBoxSettingFileName = new TextBox();
            buttonReferSettingFile = new Button();
            labelMenuFont = new Label();
            textBoxMenuFont = new TextBox();
            buttonMenuFont = new Button();
            labelMenuIconSize = new Label();
            numericUpDownMenuIconSize = new NumericUpDown();
            labelBalloonTipTimeout = new Label();
            numericUpDownBalloonTipTimeout = new NumericUpDown();
            labelChatPostMessageEndpoint = new Label();
            textBoxChatPostMessageEndpoint = new TextBox();
            labelIncomingWebhookRoot = new Label();
            textBoxIncomingWebhookRoot = new TextBox();
            labelCredTokenPrefix = new Label();
            textBoxCredTokenPrefix = new TextBox();
            labelCredWebhookPrefix = new Label();
            textBoxCredWebhookPrefix = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMenuIconSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBalloonTipTimeout).BeginInit();
            SuspendLayout();
            // 
            // labelSettingFilePath
            // 
            labelSettingFilePath.AutoSize = true;
            labelSettingFilePath.Location = new Point(3, 0);
            labelSettingFilePath.Name = "labelSettingFilePath";
            labelSettingFilePath.Size = new Size(68, 15);
            labelSettingFilePath.TabIndex = 0;
            labelSettingFilePath.Text = "設定ファイル:";
            // 
            // textBoxSettingFileName
            // 
            textBoxSettingFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSettingFileName.Location = new Point(3, 18);
            textBoxSettingFileName.Name = "textBoxSettingFileName";
            textBoxSettingFileName.ReadOnly = true;
            textBoxSettingFileName.Size = new Size(313, 23);
            textBoxSettingFileName.TabIndex = 1;
            // 
            // buttonReferSettingFile
            // 
            buttonReferSettingFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReferSettingFile.Location = new Point(322, 18);
            buttonReferSettingFile.Name = "buttonReferSettingFile";
            buttonReferSettingFile.Size = new Size(75, 23);
            buttonReferSettingFile.TabIndex = 2;
            buttonReferSettingFile.Text = "参照";
            buttonReferSettingFile.UseVisualStyleBackColor = true;
            buttonReferSettingFile.Click += buttonReferSettingFile_Click;
            // 
            // labelMenuFont
            // 
            labelMenuFont.AutoSize = true;
            labelMenuFont.Location = new Point(3, 44);
            labelMenuFont.Name = "labelMenuFont";
            labelMenuFont.Size = new Size(79, 15);
            labelMenuFont.TabIndex = 3;
            labelMenuFont.Text = "メニュー フォント:";
            // 
            // textBoxMenuFont
            // 
            textBoxMenuFont.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMenuFont.Location = new Point(3, 62);
            textBoxMenuFont.Name = "textBoxMenuFont";
            textBoxMenuFont.ReadOnly = true;
            textBoxMenuFont.Size = new Size(313, 23);
            textBoxMenuFont.TabIndex = 4;
            // 
            // buttonMenuFont
            // 
            buttonMenuFont.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMenuFont.Location = new Point(322, 62);
            buttonMenuFont.Name = "buttonMenuFont";
            buttonMenuFont.Size = new Size(75, 23);
            buttonMenuFont.TabIndex = 5;
            buttonMenuFont.Text = "変更";
            buttonMenuFont.UseVisualStyleBackColor = true;
            buttonMenuFont.Click += buttonMenuFont_Click;
            // 
            // labelMenuIconSize
            // 
            labelMenuIconSize.AutoSize = true;
            labelMenuIconSize.Location = new Point(3, 88);
            labelMenuIconSize.Name = "labelMenuIconSize";
            labelMenuIconSize.Size = new Size(73, 15);
            labelMenuIconSize.TabIndex = 6;
            labelMenuIconSize.Text = "アイコン サイズ";
            // 
            // numericUpDownMenuIconSize
            // 
            numericUpDownMenuIconSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMenuIconSize.Location = new Point(3, 106);
            numericUpDownMenuIconSize.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDownMenuIconSize.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDownMenuIconSize.Name = "numericUpDownMenuIconSize";
            numericUpDownMenuIconSize.Size = new Size(394, 23);
            numericUpDownMenuIconSize.TabIndex = 7;
            numericUpDownMenuIconSize.TextAlign = HorizontalAlignment.Right;
            numericUpDownMenuIconSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDownMenuIconSize.ValueChanged += numericUpDown_ValueChanged;
            // 
            // labelBalloonTipTimeout
            // 
            labelBalloonTipTimeout.AutoSize = true;
            labelBalloonTipTimeout.Location = new Point(3, 132);
            labelBalloonTipTimeout.Name = "labelBalloonTipTimeout";
            labelBalloonTipTimeout.Size = new Size(172, 15);
            labelBalloonTipTimeout.TabIndex = 8;
            labelBalloonTipTimeout.Text = "バルーン ヒント タイムアウト (msec.):";
            // 
            // numericUpDownBalloonTipTimeout
            // 
            numericUpDownBalloonTipTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownBalloonTipTimeout.Location = new Point(3, 150);
            numericUpDownBalloonTipTimeout.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownBalloonTipTimeout.Name = "numericUpDownBalloonTipTimeout";
            numericUpDownBalloonTipTimeout.Size = new Size(394, 23);
            numericUpDownBalloonTipTimeout.TabIndex = 9;
            numericUpDownBalloonTipTimeout.TextAlign = HorizontalAlignment.Right;
            numericUpDownBalloonTipTimeout.ValueChanged += numericUpDown_ValueChanged;
            // 
            // labelChatPostMessageEndpoint
            // 
            labelChatPostMessageEndpoint.AutoSize = true;
            labelChatPostMessageEndpoint.Location = new Point(3, 176);
            labelChatPostMessageEndpoint.Name = "labelChatPostMessageEndpoint";
            labelChatPostMessageEndpoint.Size = new Size(159, 15);
            labelChatPostMessageEndpoint.TabIndex = 10;
            labelChatPostMessageEndpoint.Text = "Slack chat.postMessage URL:";
            // 
            // textBoxChatPostMessageEndpoint
            // 
            textBoxChatPostMessageEndpoint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxChatPostMessageEndpoint.Location = new Point(3, 194);
            textBoxChatPostMessageEndpoint.Name = "textBoxChatPostMessageEndpoint";
            textBoxChatPostMessageEndpoint.ReadOnly = true;
            textBoxChatPostMessageEndpoint.Size = new Size(394, 23);
            textBoxChatPostMessageEndpoint.TabIndex = 11;
            // 
            // labelIncomingWebhookRoot
            // 
            labelIncomingWebhookRoot.AutoSize = true;
            labelIncomingWebhookRoot.Location = new Point(3, 220);
            labelIncomingWebhookRoot.Name = "labelIncomingWebhookRoot";
            labelIncomingWebhookRoot.Size = new Size(167, 15);
            labelIncomingWebhookRoot.TabIndex = 12;
            labelIncomingWebhookRoot.Text = "Incoming Webhook ルート URL:";
            // 
            // textBoxIncomingWebhookRoot
            // 
            textBoxIncomingWebhookRoot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIncomingWebhookRoot.Location = new Point(3, 238);
            textBoxIncomingWebhookRoot.Name = "textBoxIncomingWebhookRoot";
            textBoxIncomingWebhookRoot.ReadOnly = true;
            textBoxIncomingWebhookRoot.Size = new Size(394, 23);
            textBoxIncomingWebhookRoot.TabIndex = 13;
            // 
            // labelCredTokenPrefix
            // 
            labelCredTokenPrefix.AutoSize = true;
            labelCredTokenPrefix.Location = new Point(3, 264);
            labelCredTokenPrefix.Name = "labelCredTokenPrefix";
            labelCredTokenPrefix.Size = new Size(149, 15);
            labelCredTokenPrefix.TabIndex = 14;
            labelCredTokenPrefix.Text = "資格情報 トークン プレフィクス:";
            // 
            // textBoxCredTokenPrefix
            // 
            textBoxCredTokenPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCredTokenPrefix.Location = new Point(3, 282);
            textBoxCredTokenPrefix.Name = "textBoxCredTokenPrefix";
            textBoxCredTokenPrefix.ReadOnly = true;
            textBoxCredTokenPrefix.Size = new Size(394, 23);
            textBoxCredTokenPrefix.TabIndex = 15;
            // 
            // labelCredWebhookPrefix
            // 
            labelCredWebhookPrefix.AutoSize = true;
            labelCredWebhookPrefix.Location = new Point(3, 308);
            labelCredWebhookPrefix.Name = "labelCredWebhookPrefix";
            labelCredWebhookPrefix.Size = new Size(219, 15);
            labelCredWebhookPrefix.TabIndex = 16;
            labelCredWebhookPrefix.Text = "資格情報 Incoming Webhook プレフィクス:";
            // 
            // textBoxCredWebhookPrefix
            // 
            textBoxCredWebhookPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCredWebhookPrefix.Location = new Point(3, 326);
            textBoxCredWebhookPrefix.Name = "textBoxCredWebhookPrefix";
            textBoxCredWebhookPrefix.ReadOnly = true;
            textBoxCredWebhookPrefix.Size = new Size(394, 23);
            textBoxCredWebhookPrefix.TabIndex = 17;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxCredWebhookPrefix);
            Controls.Add(labelCredWebhookPrefix);
            Controls.Add(textBoxCredTokenPrefix);
            Controls.Add(labelCredTokenPrefix);
            Controls.Add(textBoxIncomingWebhookRoot);
            Controls.Add(labelIncomingWebhookRoot);
            Controls.Add(textBoxChatPostMessageEndpoint);
            Controls.Add(labelChatPostMessageEndpoint);
            Controls.Add(numericUpDownBalloonTipTimeout);
            Controls.Add(labelBalloonTipTimeout);
            Controls.Add(numericUpDownMenuIconSize);
            Controls.Add(labelMenuIconSize);
            Controls.Add(buttonMenuFont);
            Controls.Add(textBoxMenuFont);
            Controls.Add(labelMenuFont);
            Controls.Add(buttonReferSettingFile);
            Controls.Add(textBoxSettingFileName);
            Controls.Add(labelSettingFilePath);
            Name = "SettingView";
            Size = new Size(400, 352);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMenuIconSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBalloonTipTimeout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSettingFilePath;
        private TextBox textBoxSettingFileName;
        private Button buttonReferSettingFile;
        private Label labelMenuFont;
        private TextBox textBoxMenuFont;
        private Button buttonMenuFont;
        private Label labelMenuIconSize;
        private NumericUpDown numericUpDownMenuIconSize;
        private Label labelBalloonTipTimeout;
        private NumericUpDown numericUpDownBalloonTipTimeout;
        private Label labelChatPostMessageEndpoint;
        private TextBox textBoxChatPostMessageEndpoint;
        private Label labelIncomingWebhookRoot;
        private TextBox textBoxIncomingWebhookRoot;
        private Label labelCredTokenPrefix;
        private TextBox textBoxCredTokenPrefix;
        private Label labelCredWebhookPrefix;
        private TextBox textBoxCredWebhookPrefix;
    }
}
