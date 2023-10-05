namespace QuickPost.Events
{
    public class CredentialManageViewClickEventArgs : RequireAcceptEventArgs
    {
        #region Public Properties

        public string Name { get; set; } = string.Empty;

        #endregion
    }

    public delegate void CredentialManageViewClickEventHandler(object sender, CredentialManageViewClickEventArgs e);
}
