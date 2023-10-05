namespace QuickPost
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (string.Compare(args[0], "-uninstall", true) == 0)
                {
                    try
                    {
                        SettingManager.Uninstall();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "QuickPost Uninstall", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return -1;
                    }

                    return 0;
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ApplicationContext());
            return 0;
        }
    }
}
