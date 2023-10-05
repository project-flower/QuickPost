namespace QuickPost.Events
{
    public class RequireAcceptEventArgs : EventArgs
    {
        #region Public Properties

        public bool Accepted { get; set; } = false;

        #endregion
    }

    public delegate void RequireAcceptEventHandler(object sender, RequireAcceptEventArgs e);
}
