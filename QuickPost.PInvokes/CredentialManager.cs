using QuickPost.Common;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Security.Credentials;

namespace QuickPost.PInvokes
{
    [SupportedOSPlatform("windows5.1.2600")]
    public static class CredentialManager
    {
        #region Public Methods

        public static void Delete(string name)
        {
            if (!PInvoke.CredDelete(name, CRED_TYPE.CRED_TYPE_GENERIC))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }

        public unsafe static bool Exists(string name)
        {
            bool result = PInvoke.CredRead(name, CRED_TYPE.CRED_TYPE_GENERIC, out CREDENTIALW* credential);

            try
            {
                if (result)
                {
                    return true;
                }

                int lastError = Marshal.GetLastWin32Error();

                if (lastError == (int)WIN32_ERROR.ERROR_NOT_FOUND)
                {
                    // ERROR_NOT_FOUND
                    return false;
                }

                throw new Win32Exception(lastError);
            }
            finally
            {
                if (credential != null)
                {
                    PInvoke.CredFree(credential);
                }
            }
        }

        public unsafe static Credential Read(string name)
        {
            if (!PInvoke.CredRead(name, CRED_TYPE.CRED_TYPE_GENERIC, out CREDENTIALW* credential))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            if (credential == null)
            {
                throw new Exception("資格情報が見つかりません。");
            }

            try
            {
                int size = (int)credential->CredentialBlobSize;
                byte* credentialBlob = credential->CredentialBlob;
                char* password = null;

                if ((size > 1) && (credentialBlob != null))
                {
                    password = (char*)credential->CredentialBlob;
                }

                return new Credential(name, new string(credential->UserName), password, size);
            }
            finally
            {
                PInvoke.CredFree(credential);
            }
        }

        public unsafe static void Write(Credential credential)
        {
            nint bytes = Marshal.SecureStringToBSTR(credential.Password);

            try
            {
                fixed (char* nameChars = credential.Name.ToCharArray())
                fixed (char* userNameChars = credential.UserName.ToCharArray())
                {
                    CREDENTIALW credentialw = new()
                    {
                        AttributeCount = 0,
                        Attributes = null,
                        Comment = null,
                        CredentialBlob = (byte*)bytes,
                        CredentialBlobSize = (uint)(credential.Password.Length * sizeof(char)),
                        Persist = CRED_PERSIST.CRED_PERSIST_LOCAL_MACHINE,
                        TargetAlias = null,
                        TargetName = nameChars,
                        Type = CRED_TYPE.CRED_TYPE_GENERIC,
                        UserName = userNameChars
                    };

                    if (!PInvoke.CredWrite(credentialw, 0))
                    {
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    }
                }
            }
            finally
            {
                Marshal.ZeroFreeBSTR(bytes);
            }
        }

        #endregion
    }
}
