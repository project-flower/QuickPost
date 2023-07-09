using QuickPost.Events;
using QuickPost.Models;
using QuickPost.Properties;
using QuickPost.WinForms;
using System;
using System.Windows;
using System.Windows.Forms;

namespace QuickPost
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        #region Public Fields

        public bool ShowSuccessMessage = true;

        #endregion

        #region Private Fields

        private readonly NotifyIconWrapper notifyIconWrapper = new();

        #endregion

        #region Protected Methods

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            notifyIconWrapper.Dispose();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Settings settings = Settings.Default;
            ShowSuccessMessage = settings.ShowSuccessMessage;
            WebEngine.Initialize(settings.ApiEndPoint, "");
            notifyIconWrapper.BalloonTipTimeout = settings.BalloonTipTimeout;
            notifyIconWrapper.MenuItemClick += notifyIconWrapper_MenuItemClick;
        }

        #endregion

        #region Private Methods

        private void notifyIconWrapper_MenuItemClick(object sender, MenuItemClickEventArgs e)
        {
            switch (e.MenuType)
            {
                case MenuType.PostItem:
                    try
                    {
                        PostItem? postItem = e.PostItem;

                        if (postItem != null)
                        {
                            WebEngine.Post(postItem);

                            if (ShowSuccessMessage)
                            {
                                notifyIconWrapper.ShowBalloonTip($"{postItem}\r\n投稿しました。", ToolTipIcon.Info);
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        notifyIconWrapper.ShowBalloonTip(exception.Message, ToolTipIcon.Error);
                    }

                    break;
                case MenuType.Quit:
                    Shutdown();
                    break;
                case MenuType.Settings:
                    break;
            }
        }

        #endregion
    }
}
