using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class EditBookForm : Form
    {
        MySqlConnection connection;

        public EditBookForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=librarydb;user=root;password=Sandora@2095";
            connection = new MySqlConnection(connectionString);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Books SET Authors=@Authors, Title=@Title, Publisher=@Publisher, PageCount=@PageCount, Genre=@Genre, Price=@Price, LibraryStorage=@LibraryStorage WHERE BookID=@BookID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Authors", txtAuthors.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@PageCount", Convert.ToInt32(txtPageCount.Text));
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@LibraryStorage", txtLibraryStorage.Text);
                cmd.Parameters.AddWithValue("@BookID", Convert.ToInt32(txtBookID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book updated successfully");
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
