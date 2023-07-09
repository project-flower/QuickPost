using QuickPost.Events;
using QuickPost.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuickPost.WinForms
{
    public partial class NotifyIconWrapper : Component
    {
        #region Private Fields

        private readonly int defaultItemCount;

        #endregion

        #region Public Properties

        public ushort BalloonTipTimeout { get; set; } = 3000;
        public event MenuItemClickEventHandler? MenuItemClick;

        #endregion

        #region Public Methods

        public NotifyIconWrapper()
        {
            InitializeComponent();
            defaultItemCount = contextMenuStrip.Items.Count;
        }

        public void AddMenuItems(IEnumerable<PostItem> items)
        {
            ToolStripItemCollection menuItems = contextMenuStrip.Items;

            foreach (PostItem item in items)
            {
                var menuItem = new ToolStripMenuItem(item.Name) { Tag = item };
                menuItem.Click += toolStripMenuItem_Click;
                menuItems.Insert((menuItems.Count - defaultItemCount), menuItem);
            }
        }

        public void ClearItems()
        {
            ToolStripItemCollection items = contextMenuStrip.Items;

            while (items.Count > defaultItemCount)
            {
                items[0].Click -= toolStripMenuItem_Click;
                items.RemoveAt(0);
            }
        }

        public void ShowBalloonTip(string message, ToolTipIcon icon)
        {
            notifyIcon.ShowBalloonTip(BalloonTipTimeout, "QuickPost", message, icon);
        }

        #endregion

        private void toolStripMenuItem_Click(object? sender, EventArgs e)
        {
            MenuItemClick?.Invoke(this, new MenuItemClickEventArgs(MenuType.PostItem, (sender as ToolStripMenuItem)?.Tag as PostItem));
        }

        // Designer's Methods

        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            MenuItemClick?.Invoke(this, new MenuItemClickEventArgs(MenuType.Quit, null));
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            MenuItemClick?.Invoke(this, new MenuItemClickEventArgs(MenuType.Settings, null));
        }
    }
}
