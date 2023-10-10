using System.Security;

namespace QuickPost.Common
{
    public class Credential : IDisposable
    {
        #region Public Fields

        public readonly string Name;
        public readonly SecureString Password;
        public readonly string UserName;

        #endregion

        #region Public Methods

        unsafe public Credential(string name, string userName, char* password, int passwordLength)
        {
            Name = name;
            Password = new SecureString(password, passwordLength);
            Password.MakeReadOnly();
            UserName = userName;
        }

        public Credential(string name, string userName, string password)
        {
            Name = name;
            Password = new SecureString();

            foreach (char c in password)
            {
                Password.AppendChar(c);
            }

            Password.MakeReadOnly();
            UserName = userName;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(Password);
        }

        #endregion
    }
}
