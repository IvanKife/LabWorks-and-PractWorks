using System.Windows;

namespace LabWorks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataAccessLayerTextBlock.Text = DataAccessLayer.ConnectionString;
        }

        private void QueryButton_Click(object sender, RoutedEventArgs e)
        {
            if (task1RadioButton.IsChecked == true)
                try
                {
                    taskTextBlock.Text = $"Выборка одного значения: {DataAccessLayer.GetValue(queryTextBox.Text)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task2RadioButton.IsChecked == true)
                try
                {
                    dataGridQuery.ItemsSource = DataAccessLayer.GetTable(queryTextBox.Text).DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task3RadioButton.IsChecked == true)
                try
                {
                    dataGridQuery.ItemsSource = DataAccessLayer.GetBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task4RadioButton.IsChecked == true)
                try
                {
                    taskTextBlock.Text = $"Количество изменённых строк: {DataAccessLayer.GetChangedRowsCount(queryTextBox.Text)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task5RadioButton.IsChecked == true)
                try
                {
                    taskTextBlock.Text = DataAccessLayer.IsPriceChanged(Convert.ToInt32(idTextBox.Text), Convert.ToDouble(newPriceTextBox.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task6RadioButton.IsChecked == true)
                try
                {
                    dataGridQuery.ItemsSource = DataAccessLayer.GetValuesTable(nameTableTextBox.Text).DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            /* if (task7RadioButton.IsChecked == true)
                  dataGridQuery.ItemsSource = DataAccessLayer.UpdateTable().DefaultView; */

            if (task8RadioButton.IsChecked == true)
                try
                {
                    taskTextBlock.Text = $"Количество книг меньше указанной цены: {DataAccessLayer.GetBooksCountByPrice(Convert.ToDecimal(bookPriceTextBox.Text))}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task9RadioButton.IsChecked == true)
                try
                {
                    taskTextBlock.Text = $"ID созданной записи: {DataAccessLayer.AddRow(queryTextBox.Text)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task10RadioButton.IsChecked == true)
                try
                {
                    dataGridQuery.ItemsSource = DataAccessLayer.GetBooks(genreTextBox.Text, Convert.ToDecimal(priceTextBox.Text)).DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task11RadioButton.IsChecked == true)
                try
                {
                    DataAccessLayer.ChangeBookTitlePrice(Convert.ToInt32(idTextBox.Text), newTitleTextBox.Text, Convert.ToDecimal(bookPriceTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task121RadioButton.IsChecked == true)
                try
                {
                    DataAccessLayer.AddAuthor("Hello", "I", "Великобритания");
                    MessageBox.Show("Запись добавлена", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task122RadioButton.IsChecked == true)
                try
                {
                    taskTextBlock.Text = $"Последний Id добавленного автора: {DataAccessLayer.GetAuthorId("Я", "Лучший", "День")}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }

            if (task123RadioButton.IsChecked == true)
                try
                {
                    dataGridQuery.ItemsSource = DataAccessLayer.ShowBooks(100, 1000).DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось выполнить Sql-запрос {ex.Message}", "Ошибка");
                }
        }
    }
}
