using QuickPost.Views;

namespace QuickPost
{
    public class ApplicationContext : System.Windows.Forms.ApplicationContext
    {
        #region Private Fields

        private readonly FormMain formMain;

        #endregion

        #region Public Methods

        public ApplicationContext()
        {
            formMain = new();
            // 一度も表示せずに(タスクトレイに格納されたまま)終了すると FormClosed イベントが発生しないため、
            // Disposed イベントを捕捉する。
            formMain.Disposed += formMain_Disposed;

            if (formMain.MustBeShown)
            {
                // 初回起動時やエラー発生時は表示
                formMain.Show();
            }
        }

        #endregion

        #region Private Methods

        private void formMain_Disposed(object? sender, EventArgs e)
        {
            ExitThread();
        }

        #endregion
    }
}
