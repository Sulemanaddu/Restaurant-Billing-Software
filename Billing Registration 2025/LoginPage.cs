using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Billing_Registration_2025
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Corrected connection string
            string connectionString = @"Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    // Login successful, navigate to Home
                    this.Hide();
                    Home homeForm = new Home();
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials.");
                }
            }
        }
    }
}
