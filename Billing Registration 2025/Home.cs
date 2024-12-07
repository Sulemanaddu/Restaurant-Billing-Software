using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Registration_2025
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            comboBoxCategoryFilter.SelectedIndexChanged += comboBoxCategoryFilter_SelectedIndexChanged;
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;TrustServerCertificate=True;");

        private void Home_Load(object sender, EventArgs e)
        {
            LoadCategories();
            GetFoodsRecord();
        }

        private void LoadCategories()
        {
            comboBoxCategoryFilter.Items.Add("All");
            comboBoxCategoryFilter.Items.Add("Starter");
            comboBoxCategoryFilter.Items.Add("Main Course");
            comboBoxCategoryFilter.Items.Add("Beverages");
            comboBoxCategoryFilter.Items.Add("Dessert");
            comboBoxCategoryFilter.SelectedIndex = 0; // Default selection
        }

        private void GetFoodsRecord(string category = "All")
        {
            string query = category == "All"
        ? "SELECT FoodId, FoodName, FoodType, Price FROM Food"
        : "SELECT FoodId, FoodName, FoodType, Price FROM Food WHERE FoodType = @Category";

            SqlCommand cmd = new SqlCommand(query, con);

            if (category != "All")
            {
                cmd.Parameters.AddWithValue("@Category", category);
            }

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open the connection and fill the DataTable
                con.Open();
                adapter.Fill(dt);
                con.Close();

                // Bind the DataTable to the DataGridView
                HFoodDataGridView.DataSource = dt;
                HFoodDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading food records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed in case of any exception
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void comboBoxCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategoryFilter.SelectedItem.ToString();
            GetFoodsRecord(selectedCategory);
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            DataTable originalTable = HFoodDataGridView.DataSource as DataTable;

            if (originalTable != null)
            {
                // Create a new DataTable with relevant columns for the order
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("FoodId", typeof(int));
                filteredTable.Columns.Add("FoodName", typeof(string));
                filteredTable.Columns.Add("Price", typeof(decimal));
                filteredTable.Columns.Add("Quantity", typeof(int)); // For user input quantity

                foreach (DataRow row in originalTable.Rows)
                {
                    filteredTable.Rows.Add(row["FoodId"], row["FoodName"], row["Price"], 1); // Default quantity = 1
                }

                //// Pass the filtered DataTable to BillPage
                //BillPage billPage = new BillPage(filteredTable);
                //billPage.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("No food data available to display in the bill page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddUpdateDelete addUpdateDelete = new AddUpdateDelete();
            addUpdateDelete.Show();
            this.Hide();
        }

        private void btnUpdatefood_Click(object sender, EventArgs e)
        {
            AddUpdateDelete addUpdateDelete = new AddUpdateDelete();
            addUpdateDelete.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AddUpdateDelete addUpdateDelete = new AddUpdateDelete();
            addUpdateDelete.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do You Want To LogOut?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT FoodId, FoodName, FoodType, Price FROM Food WHERE FoodName LIKE @FoodName";
            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
            adapter.SelectCommand.Parameters.AddWithValue("@FoodName", "%" + valueToFind + "%");

            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);

            HFoodDataGridView.DataSource = resultTable;
            HFoodDataGridView.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearchName.Text);
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {

        }
    }
}
