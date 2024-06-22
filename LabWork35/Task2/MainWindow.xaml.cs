using Microsoft.Win32;
using System.Windows;

namespace Task2
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

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "изображение | *.png;*.jpg; *.jpeg; *.bmp",
                InitialDirectory = Environment.CurrentDirectory,
                Multiselect = true,
                Title = "Выбор изображения"
            };
            if (dialog.ShowDialog().Value != true)
                return;
            imageListView.ItemsSource = dialog.FileNames;
        }
    }
}