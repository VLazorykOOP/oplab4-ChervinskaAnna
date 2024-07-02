using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class SearchBookForm : Form
    {
        MySqlConnection connection;

        public SearchBookForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=librarydb;user=root;password=Sandora@2095";
            connection = new MySqlConnection(connectionString);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Books WHERE Title LIKE @Title";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Title", "%" + txtTitle.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtAuthors.Text = reader["Authors"].ToString();
                    txtPublisher.Text = reader["Publisher"].ToString();
                    txtPageCount.Text = reader["PageCount"].ToString();
                    txtGenre.Text = reader["Genre"].ToString();
                    txtPrice.Text = reader["Price"].ToString();
                    txtLibraryStorage.Text = reader["LibraryStorage"].ToString();
                }
                else
                {
                    MessageBox.Show("Book not found");
                }
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
