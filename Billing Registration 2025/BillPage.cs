using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Billing_Registration_2025
{
    public partial class BillPage : Form
    {
        private DataTable foodDataTable;
        private int currentBillNumber = 1; // Initialize the bill number

        // Declare the ComboBox for Waiters
        private ComboBox cbWaiters;

        public BillPage(DataTable foodDataTable)
        {
            InitializeComponent();
            SetupOFooddataGridView();
            this.foodDataTable = foodDataTable; // Store the passed DataTable reference
            InitializeWaitersComboBox(); // Initialize the waiters ComboBox
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=BillingSoftware25DB;Integrated Security=True;");

        private void SetupOFooddataGridView()
        {
            // Clear existing columns (if necessary)
            OFooddataGridView.Columns.Clear();

            // Add columns for FoodName, Quantity, and Total Price
            OFooddataGridView.Columns.Add("FoodName", "Food Name");
            OFooddataGridView.Columns.Add("Quantity", "Quantity");
            OFooddataGridView.Columns.Add("TotalPrice", "Total Price");
        }

        private void BillPage_Load(object sender, EventArgs e)
        {
            // Bind the passed DataTable to the DataGridView in BillPage
            BfoodDataGridView.DataSource = foodDataTable;
            BfoodDataGridView.Refresh();
        }

        private void InitializeWaitersComboBox()
        {
            cbWaiters = new ComboBox
            {
                Location = new Point(10, 10), // Position it appropriately
                Width = 200 // Set the width as needed
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private DataTable GetFoodDetailsById(string foodId)
        {
            DataTable foodDetails = new DataTable();
            string query = "SELECT FoodName, Price FROM food WHERE FoodId = @FoodId";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@FoodId", foodId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(foodDetails);
            }

            return foodDetails;
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodId.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter both Food ID and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the quantity is a valid number
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assume you have a method to fetch the food item details by Food ID
            DataTable foodTable = GetFoodDetailsById(txtFoodId.Text);

            if (foodTable.Rows.Count == 0)
            {
                MessageBox.Show("No food found with the given ID.", "Food Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the food details from the fetched table
            string foodName = foodTable.Rows[0]["FoodName"].ToString();
            decimal price = Convert.ToDecimal(foodTable.Rows[0]["Price"]);

            // Create a new row for OFooddataGridView
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(OFooddataGridView);

            // Assign the values to the new row
            newRow.Cells[0].Value = foodName;
            newRow.Cells[1].Value = quantity;
            newRow.Cells[2].Value = price * quantity;

            // Add the new row to the OFooddataGridView
            OFooddataGridView.Rows.Add(newRow);

            // Clear the input fields after adding
            txtFoodId.Clear();
            txtQuantity.Clear();
        }

        private void btnAddFoodInBill_Click(object sender, EventArgs e)
        {
            if (OFooddataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order to generate a bill.", "Bill Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Clear previous bill display
            pnlBillDisplay.Controls.Clear();
            decimal totalAmount = 0;
            int yPosition = 10;

            // **Restaurant Header**
            Label lblRestaurantName = new Label
            {
                Text = "HOTEL PARADISE",
                Font = new Font("Arial", 18, FontStyle.Bold),
                Location = new Point(50, yPosition),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlBillDisplay.Controls.Add(lblRestaurantName);
            yPosition += 30;

            Label lblRestaurantSubName = new Label
            {
                Text = "Veg & Non-Veg Restaurant",
                Font = new Font("Arial", 12),
                Location = new Point(50, yPosition),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlBillDisplay.Controls.Add(lblRestaurantSubName);
            yPosition += 20;

            Label lblRestaurantAddress = new Label
            {
                Text = "Sufi Complex, Manora Road, Mangrulpir\nCont: 8669284469",
                Font = new Font("Arial", 10),
                Location = new Point(20, yPosition),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlBillDisplay.Controls.Add(lblRestaurantAddress);
            yPosition += 45;

            Label lblSeparator1 = new Label
            {
                Text = new string('-', 62),
                Font = new Font("Arial", 10),
                Location = new Point(10, yPosition),
                AutoSize = true
            };
            pnlBillDisplay.Controls.Add(lblSeparator1);
            yPosition += 20;

            // **Bill Info**
            Label lblBillInfo = new Label
            {
                Text = $"Bill No: {GetNextBillNumber()}    Date: {DateTime.Now:dd/MM/yyyy}\nWaiter: {cbWaiters.SelectedItem}    Time: {DateTime.Now:HH:mm:ss}",
                Font = new Font("Arial", 10),
                Location = new Point(10, yPosition),
                AutoSize = true
            };
            pnlBillDisplay.Controls.Add(lblBillInfo);
            yPosition += 30;

            // **Separator Line**
            Label lblSeparator2 = new Label
            {
                Text = new string('-', 62),
                Font = new Font("Arial", 10),
                Location = new Point(10, yPosition),
                AutoSize = true
            };
            pnlBillDisplay.Controls.Add(lblSeparator2);
            yPosition += 20;

            // **Column Headers**
            Label lblItemHeader = new Label
            {
                Text = string.Format("{0,-25}{1,10}{2,10}{3,15}", "Item", "Qty", "Rate", "Amount"),
                Font = new Font("Arial", 10),
                Location = new Point(10, yPosition),
                AutoSize = true
            };
            pnlBillDisplay.Controls.Add(lblItemHeader);
            yPosition += 20;

            // **Separator Line**
            Label lblSeparator3 = new Label
            {
                Text = new string('-', 62),
                Font = new Font("Arial", 10),
                Location = new Point(10, yPosition),
                AutoSize = true
            };
            pnlBillDisplay.Controls.Add(lblSeparator3);
            yPosition += 20;

            // **Items**
            foreach (DataGridViewRow row in OFooddataGridView.Rows)
            {
                if (row.Cells["FoodName"].Value != null)
                {
                    string foodName = row.Cells["FoodName"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal rate = Convert.ToDecimal(row.Cells["TotalPrice"].Value) / quantity;
                    decimal itemTotal = Convert.ToDecimal(row.Cells["TotalPrice"].Value);

                    // Display the item name in a separate label to wrap long names
                    Label lblItemName = new Label
                    {
                        Text = foodName,
                        Font = new Font("Arial", 10),
                        Location = new Point(10, yPosition),
                        AutoSize = true,
                        MaximumSize = new Size(180, 0) // Wrap text if it's too long
                    };
                    pnlBillDisplay.Controls.Add(lblItemName);

                    // Display Qty, Rate, and Amount in fixed positions
                    Label lblQuantity = new Label
                    {
                        Text = quantity.ToString(),
                        Font = new Font("Arial", 10),
                        Location = new Point(200, yPosition),
                        AutoSize = true
                    };
                    pnlBillDisplay.Controls.Add(lblQuantity);

                    Label lblRate = new Label
                    {
                        Text = rate.ToString("0.00"),
                        Font = new Font("Arial", 10),
                        Location = new Point(260, yPosition),
                        AutoSize = true
                    };
                    pnlBillDisplay.Controls.Add(lblRate);

                    Label lblAmount = new Label
                    {
                        Text = itemTotal.ToString("0.00"),
                        Font = new Font("Arial", 10),
                        Location = new Point(320, yPosition),
                        AutoSize = true
                    };
                    pnlBillDisplay.Controls.Add(lblAmount);

                    // Update the yPosition for the next line
                    yPosition += 20;

                    totalAmount += itemTotal; // Accumulate the total amount
                }
            }

            // **Separator Line**
            Label lblSeparator4 = new Label
            {
                Text = new string('-', 62),
                Font = new Font("Arial", 10),
                Location = new Point(10, yPosition),
                AutoSize = true
            };
            pnlBillDisplay.Controls.Add(lblSeparator4);
            yPosition += 20;

            // **Total Amount**
            Label lblTotalAmount = new Label
            {
                Text = $"Total: {totalAmount:0.00}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(10, yPosition),
                AutoSize = true
            };
            pnlBillDisplay.Controls.Add(lblTotalAmount);
        }

        private int GetNextBillNumber()
        {
            return currentBillNumber++; // Return the current bill number and increment it
        }
    }
}
