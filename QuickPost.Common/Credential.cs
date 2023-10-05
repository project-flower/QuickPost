namespace QuickPost.Common
{
    public class Credential
    {
        #region Public Fields

        public readonly string Name;
        public readonly string Password;
        public readonly string UserName;

        #endregion

        #region Public Methods

        public Credential(string name, string userName, string password)
        {
            Name = name;
            Password = password;
            UserName = userName;
        }

        #endregion
    }
}
