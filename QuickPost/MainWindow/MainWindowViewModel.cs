using QuickPost.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPost
{
    public class MainWindowViewModel
    {
        #region Public Properties

        public string EndPoint { get; set; }
        public ObservableCollection<PostItem> PostItems { get; set; }

        #endregion
    }
}
