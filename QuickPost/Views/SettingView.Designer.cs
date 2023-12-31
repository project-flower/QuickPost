﻿namespace QuickPost.Views
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
            labelBalloonTipTimeout = new Label();
            numericUpDownBalloonTipTimeout = new NumericUpDown();
            buttonApplyBalloonTipTimeout = new Button();
            labelChatPostMessageEndpoint = new Label();
            textBoxChatPostMessageEndpoint = new TextBox();
            labelIncomingWebhookRoot = new Label();
            textBoxIncomingWebhookRoot = new TextBox();
            labelCredTokenPrefix = new Label();
            textBoxCredTokenPrefix = new TextBox();
            labelCredWebhookPrefix = new Label();
            textBoxCredWebhookPrefix = new TextBox();
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
            // labelBalloonTipTimeout
            // 
            labelBalloonTipTimeout.AutoSize = true;
            labelBalloonTipTimeout.Location = new Point(3, 44);
            labelBalloonTipTimeout.Name = "labelBalloonTipTimeout";
            labelBalloonTipTimeout.Size = new Size(172, 15);
            labelBalloonTipTimeout.TabIndex = 3;
            labelBalloonTipTimeout.Text = "バルーン ヒント タイムアウト (msec.):";
            // 
            // numericUpDownBalloonTipTimeout
            // 
            numericUpDownBalloonTipTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownBalloonTipTimeout.Location = new Point(3, 62);
            numericUpDownBalloonTipTimeout.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownBalloonTipTimeout.Name = "numericUpDownBalloonTipTimeout";
            numericUpDownBalloonTipTimeout.Size = new Size(313, 23);
            numericUpDownBalloonTipTimeout.TabIndex = 4;
            numericUpDownBalloonTipTimeout.TextAlign = HorizontalAlignment.Right;
            numericUpDownBalloonTipTimeout.ValueChanged += numericUpDownBalloonTipTimeout_ValueChanged;
            // 
            // buttonApplyBalloonTipTimeout
            // 
            buttonApplyBalloonTipTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonApplyBalloonTipTimeout.Enabled = false;
            buttonApplyBalloonTipTimeout.Location = new Point(322, 62);
            buttonApplyBalloonTipTimeout.Name = "buttonApplyBalloonTipTimeout";
            buttonApplyBalloonTipTimeout.Size = new Size(75, 23);
            buttonApplyBalloonTipTimeout.TabIndex = 5;
            buttonApplyBalloonTipTimeout.Text = "適用";
            buttonApplyBalloonTipTimeout.UseVisualStyleBackColor = true;
            buttonApplyBalloonTipTimeout.Click += buttonApplyBalloonTipTimeout_Click;
            // 
            // labelChatPostMessageEndpoint
            // 
            labelChatPostMessageEndpoint.AutoSize = true;
            labelChatPostMessageEndpoint.Location = new Point(3, 88);
            labelChatPostMessageEndpoint.Name = "labelChatPostMessageEndpoint";
            labelChatPostMessageEndpoint.Size = new Size(159, 15);
            labelChatPostMessageEndpoint.TabIndex = 6;
            labelChatPostMessageEndpoint.Text = "Slack chat.postMessage URL:";
            // 
            // textBoxChatPostMessageEndpoint
            // 
            textBoxChatPostMessageEndpoint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxChatPostMessageEndpoint.Location = new Point(3, 106);
            textBoxChatPostMessageEndpoint.Name = "textBoxChatPostMessageEndpoint";
            textBoxChatPostMessageEndpoint.ReadOnly = true;
            textBoxChatPostMessageEndpoint.Size = new Size(394, 23);
            textBoxChatPostMessageEndpoint.TabIndex = 7;
            // 
            // labelIncomingWebhookRoot
            // 
            labelIncomingWebhookRoot.AutoSize = true;
            labelIncomingWebhookRoot.Location = new Point(3, 132);
            labelIncomingWebhookRoot.Name = "labelIncomingWebhookRoot";
            labelIncomingWebhookRoot.Size = new Size(167, 15);
            labelIncomingWebhookRoot.TabIndex = 8;
            labelIncomingWebhookRoot.Text = "Incoming Webhook ルート URL:";
            // 
            // textBoxIncomingWebhookRoot
            // 
            textBoxIncomingWebhookRoot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIncomingWebhookRoot.Location = new Point(3, 150);
            textBoxIncomingWebhookRoot.Name = "textBoxIncomingWebhookRoot";
            textBoxIncomingWebhookRoot.ReadOnly = true;
            textBoxIncomingWebhookRoot.Size = new Size(394, 23);
            textBoxIncomingWebhookRoot.TabIndex = 9;
            // 
            // labelCredTokenPrefix
            // 
            labelCredTokenPrefix.AutoSize = true;
            labelCredTokenPrefix.Location = new Point(3, 176);
            labelCredTokenPrefix.Name = "labelCredTokenPrefix";
            labelCredTokenPrefix.Size = new Size(149, 15);
            labelCredTokenPrefix.TabIndex = 10;
            labelCredTokenPrefix.Text = "資格情報 トークン プレフィクス:";
            // 
            // textBoxCredTokenPrefix
            // 
            textBoxCredTokenPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCredTokenPrefix.Location = new Point(3, 194);
            textBoxCredTokenPrefix.Name = "textBoxCredTokenPrefix";
            textBoxCredTokenPrefix.ReadOnly = true;
            textBoxCredTokenPrefix.Size = new Size(394, 23);
            textBoxCredTokenPrefix.TabIndex = 11;
            // 
            // labelCredWebhookPrefix
            // 
            labelCredWebhookPrefix.AutoSize = true;
            labelCredWebhookPrefix.Location = new Point(3, 220);
            labelCredWebhookPrefix.Name = "labelCredWebhookPrefix";
            labelCredWebhookPrefix.Size = new Size(219, 15);
            labelCredWebhookPrefix.TabIndex = 12;
            labelCredWebhookPrefix.Text = "資格情報 Incoming Webhook プレフィクス:";
            // 
            // textBoxCredWebhookPrefix
            // 
            textBoxCredWebhookPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCredWebhookPrefix.Location = new Point(3, 238);
            textBoxCredWebhookPrefix.Name = "textBoxCredWebhookPrefix";
            textBoxCredWebhookPrefix.ReadOnly = true;
            textBoxCredWebhookPrefix.Size = new Size(394, 23);
            textBoxCredWebhookPrefix.TabIndex = 13;
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
            Controls.Add(buttonApplyBalloonTipTimeout);
            Controls.Add(numericUpDownBalloonTipTimeout);
            Controls.Add(labelBalloonTipTimeout);
            Controls.Add(buttonReferSettingFile);
            Controls.Add(textBoxSettingFileName);
            Controls.Add(labelSettingFilePath);
            Name = "SettingView";
            Size = new Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)numericUpDownBalloonTipTimeout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSettingFilePath;
        private TextBox textBoxSettingFileName;
        private Button buttonReferSettingFile;
        private Label labelBalloonTipTimeout;
        private NumericUpDown numericUpDownBalloonTipTimeout;
        private Button buttonApplyBalloonTipTimeout;
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
