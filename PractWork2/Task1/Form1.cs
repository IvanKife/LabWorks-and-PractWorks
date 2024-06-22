namespace Task1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string filename = "logins.csv";
            var data = File.ReadAllLines(filename);
            for (int i = 0; i < data.Length; i++)
            {
                if (loginTextBox.Text == data[i].ToString())
                    MessageBox.Show("Введите логин повторно");
            }
            MessageBox.Show("Вы успешно зарегистрировались");
        }
    }
}
