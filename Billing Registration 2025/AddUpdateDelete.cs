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
    public partial class AddUpdateDelete : Form
    {
        public AddUpdateDelete()
        {
            InitializeComponent();
            LoadCategories(); // Load categories into ComboBox
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=BillingSoftware25DB;Integrated Security=True;");

        private void AddUpdateDelete_Load(object sender, EventArgs e)
        {
            // Validation for fields when loading the form
            if (string.IsNullOrWhiteSpace(txtFoodName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill out all fields before adding food.");
                return;
            }

            string foodName = txtFoodName.Text;

            // Validate and parse the price
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            string connectionString = @"Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;TrustServerCertificate=True;";
            string query = "INSERT INTO FoodItems (FoodName, Price) VALUES (@foodName, @price)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@foodName", foodName);
                    cmd.Parameters.AddWithValue("@price", price);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Food item added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            // Adding predefined categories to comboBoxCategory
            comboBoxCategory.Items.Add("Starter");
            comboBoxCategory.Items.Add("Main Course");
            comboBoxCategory.Items.Add("Beverages");
            comboBoxCategory.Items.Add("Dessert");
            comboBoxCategory.SelectedIndex = 0; // Set default selection
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnAddFoodCRUD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please enter valid food details.");
                return;
            }

            string foodName = txtFoodName.Text;

            // Validate and parse the price
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            string connectionString = @"Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;TrustServerCertificate=True";
            string query = "INSERT INTO FoodItems (FoodName, Price) VALUES (@foodName, @price)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@foodName", foodName);
                cmd.Parameters.AddWithValue("@price", price);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Food item added successfully!");
            }
        }

        private void btnGetDataCURD_Click(object sender, EventArgs e)
        {
            int foodId;

            // Validate and parse Food ID
            if (int.TryParse(txtFoodId.Text, out foodId))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM FoodItems WHERE FoodId = @FoodId", con);
                cmd.Parameters.AddWithValue("@FoodId", foodId);

                try
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    // If data is found, populate the fields
                    if (dr.Read())
                    {
                        txtFoodName.Text = dr["FoodName"].ToString();
                        comboBoxCategory.SelectedItem = dr["FoodCategory"].ToString();
                        txtFoodDescription.Text = dr["FoodDescription"].ToString();
                        txtPrice.Text = dr["Price"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Food item not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Food ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdatefoodCRUD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodId.Text) || string.IsNullOrWhiteSpace(txtFoodName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please enter valid details.");
                return;
            }

            // Validate and parse the Food ID and Price
            if (!int.TryParse(txtFoodId.Text, out int foodId))
            {
                MessageBox.Show("Invalid Food ID. Please enter a valid number.");
                return;
            }

            string foodName = txtFoodName.Text;

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            string connectionString = @"Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;TrustServerCertificate=True";
            string query = "UPDATE FoodItems SET FoodName = @foodName, Price = @price WHERE FoodId = @foodId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@foodId", foodId);
                cmd.Parameters.AddWithValue("@foodName", foodName);
                cmd.Parameters.AddWithValue("@price", price);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Food item updated successfully!");
            }
        }

        private void btnDeleteFoodCRUD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodId.Text))
            {
                MessageBox.Show("Please enter a valid Food ID.");
                return;
            }

            // Validate and parse the Food ID
            if (!int.TryParse(txtFoodId.Text, out int foodId))
            {
                MessageBox.Show("Invalid Food ID. Please enter a valid number.");
                return;
            }

            string connectionString = @"Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;TrustServerCertificate=True";
            string query = "DELETE FROM FoodItems WHERE FoodId = @foodId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@foodId", foodId);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Food item deleted successfully!");
            }
        }
    }
}
