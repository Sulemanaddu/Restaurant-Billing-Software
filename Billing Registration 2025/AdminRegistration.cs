using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Registration_2025
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }




        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string role = "Admin"; // Assign a default role, or retrieve from a dropdown/field.

            // Database connection
            string connectionString = "Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;TrustServerCertificate=True;";
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role); // Add role parameter
                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin registered successfully!");
                    this.Hide();
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                }
                else
                {
                    MessageBox.Show("Error in registration.");
                }
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
