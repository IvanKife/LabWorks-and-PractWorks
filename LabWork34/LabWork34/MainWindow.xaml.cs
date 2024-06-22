using System.Windows;
using System.Windows.Controls;

namespace LabWork34
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dateTimeStatusBarItem.Content = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e) => 
            countStatusBarItem.Content = $"Количество символов: {inputTextBox.Text.Count()}";

        private void StatusMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if (conditionStatusBar != null)
                conditionStatusBar.Visibility = Visibility.Visible;
        }

        private void StatusMenuItem_Unchecked(object sender, RoutedEventArgs e) => 
            conditionStatusBar.Visibility = Visibility.Collapsed;

        private void ClearMenuItem_Click(object sender, RoutedEventArgs e) => 
            inputTextBox.Clear();

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e) => 
            Close();
    }
}