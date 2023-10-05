using QuickPost.Models;

namespace QuickPost.Events
{
    public class MainViewClickEventArgs : RequireAcceptEventArgs
    {
        #region Public Properties

        public PostItem? Item { get; set; } = null;

        #endregion
    }

    public delegate void MainViewClickEventHandler(object sender, MainViewClickEventArgs e);
}
