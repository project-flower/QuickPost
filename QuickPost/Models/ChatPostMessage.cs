namespace QuickPost.Models
{
    public class ChatPostMessage : PostItem
    {
        #region Public Properties

        public string Channel { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string TokenName { get; set; } = string.Empty;

        #endregion
    }
}
