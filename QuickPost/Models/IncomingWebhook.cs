namespace QuickPost.Models
{
    public class IncomingWebhook : PostItem
    {
        #region Public Properties

        public string EndpointName { get; set; } = string.Empty;
        public string Payload { get; set; } = string.Empty;

        #endregion
    }
}
