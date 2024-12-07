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
    public partial class TotalOrders : Form
    {
        public TotalOrders()
        {
            InitializeComponent();
        }

        private void TotalOrders_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=RestaurantBillingDN2;Integrated Security=True;Trust Server Certificate=True";
            string query = "SELECT * FROM Orders";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                //dgvOrders.DataSource = dt;
            }
        }
    }
}
