using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class LoginForm : Form
    {
        MySqlConnection connection;

        public LoginForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=librarydb;user=root;password=Sandora@2095";
            connection = new MySqlConnection(connectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Login successful");
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
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
