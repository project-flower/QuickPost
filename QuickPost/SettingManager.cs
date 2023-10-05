using System.Configuration;

namespace QuickPost
{
    internal static class SettingManager
    {
        #region Internal Methods

        internal static string GetFilePath()
        {
            try
            {
                return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
            }
            catch
            {
                throw;
            }

        }

        internal static void Uninstall()
        {
            try
            {
                string fileName = GetFilePath();

                if (!File.Exists(fileName)) return;

                string directoryName = Path.GetDirectoryName(fileName)!;
                string deleteTarget = fileName;

                while (Directory.GetFileSystemEntries(directoryName).Length == 1)
                {
                    deleteTarget = directoryName;
                    directoryName = Path.GetDirectoryName(directoryName)!;
                }

                if (File.Exists(deleteTarget))
                {
                    File.Delete(deleteTarget);
                }
                else if (Directory.Exists(deleteTarget))
                {
                    Directory.Delete(deleteTarget, true);
                }
            }
            catch
            {
                throw;
            }
        }

        #endregion
    }
}
