using System.Text.Json.Serialization;

namespace QuickPost.Models
{
    [JsonDerivedType(typeof(ChatPostMessage), typeDiscriminator: "ChatPostMessage")]
    [JsonDerivedType(typeof(IncomingWebhook), typeDiscriminator: "IncomingWebhook")]
    public abstract class PostItem
    {
        #region Public Properties

        public string Name { get; set; } = string.Empty;

        #endregion

        #region Public Methods

        public PostItem Clone()
        {
            return (PostItem)MemberwiseClone();
        }

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}
