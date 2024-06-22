using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LabWorks
{
    public static class DataAccessLayer
    {
        public static string ServerName { get; set; } = @"prserver\SQLEXPRESS";
        public static string DataBaseName { get; set; } = "ispp2112";
        public static string Login { get; set; } = "ispp2112";
        public static string Password { get; set; } = "2112";
        public static string ConnectionString // Task1 FROM LR45
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = ServerName,
                    UserID = Login,
                    Password = Password,
                    InitialCatalog = DataBaseName,
                    TrustServerCertificate = true
                };

                return builder.ConnectionString;
            }
        }

        public static object GetValue(string query) // Task2 FROM LR45
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);

            return command.ExecuteScalar();
        }

        public static DataTable GetTable(string query) // Task3 FROM LR45
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);

            using SqlDataAdapter adapter = new(query, connection);
            DataTable table = new();

            adapter.Fill(table);

            return table;
        }

        public static List<Book> GetBooks() // Task4 FROM LR45
        {           
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT * FROM Book";
            SqlCommand command = new(query, connection);
            List<Book> books = new();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var book = new Book
                {
                    BookId = (int)reader["BookId"],
                    Title = reader["Title"].ToString(),
                    Price = Convert.ToDouble(reader["Price"])
                };
                books.Add(book);
            }

            return books;
        }

        public static int GetChangedRowsCount(string query) // Task1 FROM LR46
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);

            return command.ExecuteNonQuery();
        }

        public static bool IsPriceChanged(int bookId, double newPrice) // Task2 FROM LR46
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            var query = $"UPDATE Book SET Price = {newPrice} WHERE BookId = {bookId}";

            SqlCommand command = new(query, connection);
            command.ExecuteNonQuery();

            return true;
        }

        public static DataTable GetValuesTable(string tableName) // Task3 FROM LR46
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"SELECT * FROM {tableName}";
            SqlCommand command = new(query, connection);

            using SqlDataAdapter adapter = new(query, connection);
            DataTable table = new();

            adapter.Fill(table);

            return table;
        }

        public static void UpdateTable(ref DataTable table, string tableName) // Task4 FROM LR46
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"SELECT * From {tableName}";
            SqlCommand command = new(query, connection);

            using SqlDataAdapter adapter = new(query, connection);
            SqlCommandBuilder builder = new(adapter);
            adapter.Update(table); // отправка изменений в БД

            // обновление данных в таблице (в локальной копии)
            table.Clear();
            adapter.Fill(table); // загрузка данных в table 
        }

        public static int GetBooksCountByPrice(decimal price) // Task1 FROM LR47
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"SELECT COUNT(*) FROM Book WHERE Price < @price";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@price", price);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static int AddRow(string query) // Task2 FROM LR47
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new($"{query};SET @id=SCOPE_IDENTITY()", connection);
            SqlParameter lastId = new("@id", SqlDbType.Int);

            lastId.Direction = ParameterDirection.Output;
            command.Parameters.Add(lastId);

            command.ExecuteNonQuery();

            return Convert.ToInt32(lastId.Value);
        }

        public static DataTable GetBooks(string genre, decimal price) // Task3 FROM LR47
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"SELECT * FROM Book WHERE Genre = @genre AND Price < @price";
            SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@genre", genre);
            command.Parameters.AddWithValue("@price", price);

            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new();
            table.Load(reader);

            return table;
        }

        public static void ChangeBookTitlePrice(int bookId, string title, decimal price) // Task4 FROM LR47
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"UPDATE Book SET Title = @title, Price = @price WHERE BookId = @bookId";
            SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@bookId", bookId);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@price", price);

            command.ExecuteNonQuery();

            MessageBox.Show("Данные изменены");
        }

        public static void AddAuthor(string surname, string name, string country) // Task2 FROM LR48
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "AddAuthor";
            SqlCommand command = new(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);

            command.ExecuteNonQuery();
        }

        public static int GetAuthorId(string surname, string name, string country) // Task3 FROM LR48
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "AddAuthorWithId";

            SqlCommand command = new(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static DataTable ShowBooks(decimal minPrice, decimal maxPrice) // Task4 FROM LR48
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "ShowBooks";

            DataTable table = new();

            using SqlDataAdapter adapter = new(query, connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand.Parameters.AddWithValue("@minPrice", minPrice);
            adapter.SelectCommand.Parameters.AddWithValue("@maxPrice", maxPrice);

            adapter.Fill(table);

            return table;
        }
    }
}
