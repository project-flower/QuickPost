using QuickPost.Models;
using System;

namespace QuickPost.Events
{
    public class MenuItemClickEventArgs : EventArgs
    {
        #region Public Properties

        public MenuType MenuType { get; }
        public PostItem? PostItem { get; }

        #endregion

        #region Public Methods

        public MenuItemClickEventArgs(MenuType menuType, PostItem? postItem)
        {
            MenuType = menuType;
            PostItem = postItem;
        }

        #endregion
    }

    public delegate void MenuItemClickEventHandler(object sender, MenuItemClickEventArgs e);
}
