using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork31
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

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text != string.Empty &&
               ParolePasswordBox.Password != string.Empty &&
               ConfirmPasswordBox.Password != string.Empty &&
               InfoTextBox.Text != string.Empty &&
               ParolePasswordBox.Password == ConfirmPasswordBox.Password)
                MessageBox.Show($"{LoginTextBox.Text}, вы зарегистрированы");
            else
                MessageBox.Show("Заполните все поля ввода или проверьте совпадение паролей");
        }

        private void BirthdayDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        { 
            AgeLabel.Content = DateTime.Now.Year - BirthdayDatePicker.SelectedDate.Value.Year;
        }
    }
}