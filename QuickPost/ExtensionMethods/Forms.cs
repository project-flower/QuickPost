namespace QuickPost.ExtensionMethods
{
    public static partial class Forms
    {
        #region Private Fields

        private static bool dialogShowing = false;

        #endregion

        #region Public Methods

        public static void ShowErrorMessage(this Form form, Exception exception)
        {
            ShowErrorMessage(form, exception.Message);
        }

        public static void ShowErrorMessage(this Form form, string message)
        {
            ShowMessage(form, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformation(this Form form, string message)
        {
            ShowMessage(form, message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowMessage(this Form form, string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (dialogShowing)
            {
                return DialogResult.None;
            }

            dialogShowing = true;
            DialogResult result = MessageBox.Show(form, text, form.Text, buttons, icon);
            dialogShowing = false;
            return result;
        }

        #endregion
    }
}
