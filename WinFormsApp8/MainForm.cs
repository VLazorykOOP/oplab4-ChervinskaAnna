using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                string connectionString = "server=localhost;database=librarydb;user=root;password=Sandora@2095";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT BookID, Authors, Title, Publisher, PageCount, Genre, Price, LibraryStorage FROM Books";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
            LoadBooks(); // Refresh data after adding a book
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            EditBookForm editBookForm = new EditBookForm();
            editBookForm.ShowDialog();
            LoadBooks(); // Refresh data after editing a book
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchBookForm searchBookForm = new SearchBookForm();
            searchBookForm.ShowDialog();
        }

        private void btnOrderBook_Click(object sender, EventArgs e)
        {
            OrderBookForm orderBookForm = new OrderBookForm();
            orderBookForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
