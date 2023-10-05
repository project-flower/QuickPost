using QuickPost.Events;
using QuickPost.Models;

namespace QuickPost.Views
{
    public partial class MainView : UserControl
    {
        #region Public Properties

        public event MainViewClickEventHandler AddClick = delegate { };
        public event MainViewClickEventHandler DeleteClick = delegate { };
        public event MainViewClickEventHandler EditClick = delegate { };
        public bool IsDirty { get; private set; }

        public IEnumerable<PostItem> Items
        {
            get
            {
                foreach (ListViewItem item in listView.Items)
                {
                    yield return (PostItem)item.Tag;
                }
            }

            set
            {
                listView.BeginUpdate();
                listView.Items.Clear();

                foreach (PostItem postItem in value)
                {
                    AddItem(postItem);
                }

                listView.EndUpdate();
                IsDirty = false;
            }
        }

        #endregion

        #region Public Methods

        public MainView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            listView.Items.Clear();
        }

        #endregion

        #region Private Methods

        private void AddItem(PostItem item)
        {
            listView.Items.Add(GenerateListViewItem(item));
        }

        private ListViewItem GenerateListViewItem(PostItem postItem)
        {
            string api;

            if (postItem is ChatPostMessage)
            {
                api = "Chat";
            }
            else if (postItem is IncomingWebhook)
            {
                api = "Hook";
            }
            else
            {
                api = string.Empty;
            }

            ListViewItem result = new(api) { Tag = postItem };
            result.SubItems.Add(postItem.Name);
            return result;
        }

        private bool OccurrButtonClickEvent(MainViewClickEventHandler eventHandler, out int selectedIndex, out MainViewClickEventArgs? eventArgs)
        {
            ListView.SelectedIndexCollection selectedIndices = listView.SelectedIndices;

            if ((selectedIndices == null) || (selectedIndices.Count < 1))
            {
                selectedIndex = -1;
                eventArgs = null;
                return false;
            }

            selectedIndex = selectedIndices[0];
            var postItem = ((PostItem)listView.Items[selectedIndex].Tag).Clone();
            eventArgs = new() { Item = postItem };
            eventHandler(this, eventArgs);
            return eventArgs.Accepted;
        }

        #endregion

        // Designer's Methods

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MainViewClickEventArgs args = new();
            AddClick(this, args);

            if (!args.Accepted) return;

            AddItem(args.Item!);
            IsDirty = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!OccurrButtonClickEvent(DeleteClick, out int selectedIndex, out MainViewClickEventArgs? _)) return;

            listView.Items.RemoveAt(selectedIndex);
            IsDirty = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!OccurrButtonClickEvent(EditClick, out int selectedIndex, out MainViewClickEventArgs? evetnArgs)) return;

            listView.Items[selectedIndex] = GenerateListViewItem(evetnArgs!.Item!);
            IsDirty = true;
        }
    }
}
