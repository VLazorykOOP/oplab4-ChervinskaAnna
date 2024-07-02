using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class AddBookForm : Form
    {
        MySqlConnection connection;

        public AddBookForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=librarydb;user=root;password=Sandora@2095";
            connection = new MySqlConnection(connectionString);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Books (Authors, Title, Publisher, PageCount, Genre, Price, LibraryStorage) VALUES (@Authors, @Title, @Publisher, @PageCount, @Genre, @Price, @LibraryStorage)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Authors", txtAuthors.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@PageCount", Convert.ToInt32(txtPageCount.Text));
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@LibraryStorage", txtLibraryStorage.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
