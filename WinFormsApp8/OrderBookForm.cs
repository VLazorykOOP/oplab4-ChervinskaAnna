using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class OrderBookForm : Form
    {
        MySqlConnection connection;

        public OrderBookForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=librarydb;user=root;password=Sandora@2095";
            connection = new MySqlConnection(connectionString);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Orders (BookID, Quantity, OrderDate) VALUES (@BookID, @Quantity, @OrderDate)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@BookID", Convert.ToInt32(txtBookID.Text));
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order placed successfully");
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
