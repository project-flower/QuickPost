using QuickPost.Events;

namespace QuickPost.Views
{
    public partial class CredentialManageView : UserControl
    {
        #region Public Properties

        public event CredentialManageViewClickEventHandler AddClick = delegate { };
        public event CredentialManageViewClickEventHandler DeleteClick = delegate { };
        public event CredentialManageViewClickEventHandler EditClick = delegate { };

        public bool IsDirty { get; set; } = false;

        public IEnumerable<string> Values
        {
            get
            {
                foreach (object item in listBox.Items)
                {
                    yield return item.ToString()!;
                }
            }

            set
            {
                ListBox.ObjectCollection items = listBox.Items;
                listBox.BeginUpdate();
                items.Clear();

                foreach (object item in value)
                {
                    items.Add(item);
                }

                listBox.EndUpdate();

                IsDirty = false;
            }
        }

        #endregion

        #region Public Methods

        public CredentialManageView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            listBox.Items.Clear();
            IsDirty = false;
        }

        #endregion

        #region Private Methods

        private bool OccurrButtonClickEvent(CredentialManageViewClickEventHandler eventHandler, out int selectedIndex, out CredentialManageViewClickEventArgs? eventArgs)
        {
            selectedIndex = listBox.SelectedIndex;

            if (selectedIndex < 0)
            {
                eventArgs = null;
                return false;
            }

            eventArgs = new CredentialManageViewClickEventArgs()
            {
                Name = listBox.Items[selectedIndex].ToString()!
            };

            eventHandler(eventHandler, eventArgs);
            return eventArgs.Accepted;
        }

        #endregion

        // Designer's Methods

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var args = new CredentialManageViewClickEventArgs();
            AddClick(this, args);

            if (!args.Accepted) return;

            listBox.Items.Add(args.Name);
            IsDirty = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!OccurrButtonClickEvent(DeleteClick, out int selectedIndex, out _)) return;

            listBox.Items.RemoveAt(selectedIndex);
            IsDirty = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!OccurrButtonClickEvent(EditClick, out int selectedIndex, out CredentialManageViewClickEventArgs? eventArgs)) return;

            listBox.Items[selectedIndex] = eventArgs!.Name;
            IsDirty = true;
        }
    }
}
