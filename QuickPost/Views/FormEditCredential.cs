using QuickPost.ExtensionMethods;

namespace QuickPost.Views
{
    public partial class FormEditCredential : Form
    {
        #region Public Properties

        public string NameOfValue
        {
            get => labelValue.Text;
            set => labelValue.Text = value;
        }

        public string Value
        {
            get => textBoxValue.Text;
            set => textBoxValue.Text = value;
        }

        public string ValueOfName
        {
            get => textBoxName.Text;
            set => textBoxName.Text = value;
        }

        #endregion

        #region Public Methods

        public FormEditCredential()
        {
            InitializeComponent();
            MaximumSize = new Size(int.MaxValue, Height);
            MinimumSize = Size;
        }

        public DialogResult ShowDialog(IWin32Window? owner, bool nameEditable)
        {
            labelName.Enabled = nameEditable;
            textBoxName.Enabled = nameEditable;
            return base.ShowDialog(owner);
        }

        [Obsolete("Use ShowDialog(IWin32Window?, bool).")]
        public new DialogResult ShowDialog()
        {
            return base.ShowDialog();
        }

        [Obsolete("Use ShowDialog(IWin32Window?, bool).")]
        public new DialogResult ShowDialog(IWin32Window? owner)
        {
            return base.ShowDialog(owner);
        }

        #endregion

        // Designer's Methods

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxValue.Text))
            {
                this.ShowMessage($"名前 または {labelValue.Text}\r\nは空にできません。", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
