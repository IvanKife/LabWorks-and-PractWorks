using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace LabWork35
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
                Filter = "текстовые|*.txt |программные| *.cs;*.html;*.css;*.js;*.sql",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Выбор файла"
            };

            if (dialog.ShowDialog().Value != true)
                return;
            textBox.Text = File.ReadAllText(dialog.FileName);
            Title = dialog.FileName;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "текстовые|*.txt |программные| *.cs;*.html;*.css;*.js;*.sql",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Сохранение"
            };

            if (dialog.ShowDialog().Value != true)
                return;
            File.WriteAllText(dialog.FileName, textBox.Text);
            MessageBox.Show("Файл сохранён");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть приложение?", "Закрытие",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;
        }
    }
}