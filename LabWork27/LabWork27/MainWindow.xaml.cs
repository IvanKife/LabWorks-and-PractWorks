using System.Windows;

namespace LabWork27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ContentFrame.Navigate(new Pages.StartPage());
            Manager.MainFrame = ContentFrame;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void ContentFrame_ContentRendered(object sender, EventArgs e)
        {
            if (ContentFrame.CanGoBack)
                GoBackButton.Visibility = Visibility.Visible;
            else
                GoBackButton.Visibility = Visibility.Collapsed;
        }
    }
}