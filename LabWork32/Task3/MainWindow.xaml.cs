using System.Windows;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>()
            {
                new User{Id=1, Login="user1337", Password = "qwerty"},
                new User{Id=2, Login="user228", Password = "QwerTy"},
                new User{Id=3, Login="user14", Password = "NOTqwerty"},
                new User{Id=4, Login="user88", Password = "CoolQwerty"},
                new User{Id=5, Login="Admin", Password = "BossQwerty"},
            };
            listBox.ItemsSource = users;
            comboBox.ItemsSource = users;
            listView.ItemsSource = users;
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            User user = (User)comboBox.SelectedItem;
            labelComboBox.Content = $"{user.Id} {user.Login} {user.Password}";
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in listBox.SelectedItems)
                users += $"{user.Login}\n";
            labelListBox.Content = users;
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in listView.SelectedItems)
                users += $"{user.Login}\n";
            labelListView.Content = users;
        }
    }
}