using System.Windows;

namespace LabWork30
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubscribeCheckBox_Checked(object sender, RoutedEventArgs e) 
            => SubscribeButton.IsEnabled = true;

        private void SubscribeCheckBox_Unchecked(object sender, RoutedEventArgs e) 
            => SubscribeButton.IsEnabled = false;
    }
}