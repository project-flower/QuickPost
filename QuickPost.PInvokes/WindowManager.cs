using System.Runtime.Versioning;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace QuickPost.PInvokes
{
    public static class WindowManager
    {
        #region Public Methods

        [SupportedOSPlatform("windows5.0")]
        public static bool SetForegroundWindow(IntPtr handle)
        {
            return PInvoke.SetForegroundWindow(new HWND(handle));
        }

        #endregion
    }
}
