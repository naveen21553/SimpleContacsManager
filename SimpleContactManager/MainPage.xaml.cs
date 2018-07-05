using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleContactManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { IconSource = "Assets/female-01.png" });
            Icons.Add(new Icon { IconSource = "Assets/female-02.png" });
            Icons.Add(new Icon { IconSource = "Assets/female-03.png" });
            Icons.Add(new Icon { IconSource = "Assets/male-01.png" });
            Icons.Add(new Icon { IconSource = "Assets/male-02.png" });
            Icons.Add(new Icon { IconSource = "Assets/male-03.png" });

            Contacts = new ObservableCollection<Contact>();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)AvatarComboBox.SelectedValue).IconSource;
            Contacts.Add(new Contact { FirstName = FirstNameBox.Text, Avatar = avatar, LastName=LastNameBox.Text});
        }
    }
}
