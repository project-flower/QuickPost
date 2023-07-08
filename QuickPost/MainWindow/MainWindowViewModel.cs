using QuickPost.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuickPost
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private Fidlds

        private string endPoint = string.Empty;

        #endregion

        #region Public Properties

        public string EndPoint
        {
            get => endPoint;

            set
            {
                endPoint = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<PostItem> PostItems { get; set; } = new();
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Public Methods

        public MainWindowViewModel()
        {
            //PostItems.CollectionChanged += postItems_CollectionChanged;
#if DEBUG
            EndPoint = "えんどぽいんと";
            PostItems.Add(new PostItem() { Channel = "ちゃんねる", Message = "めっせーじ" });
#endif
        }

        #endregion

        #region Private Methods

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //private void postItems_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    NotifyPropertyChanged(nameof(PostItems));
        //}

        #endregion
    }
}
