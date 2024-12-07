namespace Billing_Registration_2025
{
    partial class BillPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button2 = new Button();
            BfoodDataGridView = new DataGridView();
            FoodID = new DataGridViewTextBoxColumn();
            FoodNameTF = new DataGridViewTextBoxColumn();
            FoodPriceTF = new DataGridViewTextBoxColumn();
            OFooddataGridView = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            FoodPrice = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnOrderFood = new Button();
            txtQuantity = new TextBox();
            //txtFoodId = new TextBox();
            txtMobileNumber = new TextBox();
            txtuserName = new TextBox();
            textBox5 = new TextBox();
            btnAddFoodInBill = new Button();
            btnCancel = new Button();
            btnPrint = new Button();
            comboBox1 = new ComboBox();

            ((System.ComponentModel.ISupportInitialize)BfoodDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OFooddataGridView).BeginInit();
            SuspendLayout();

            // DataGridView setup (BfoodDataGridView)
            BfoodDataGridView.Anchor = AnchorStyles.None;
            BfoodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BfoodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BfoodDataGridView.Columns.AddRange(new DataGridViewColumn[] { FoodID, FoodNameTF, FoodPriceTF });
            BfoodDataGridView.Location = new Point(12, 219);
            BfoodDataGridView.Name = "BfoodDataGridView";
            BfoodDataGridView.RowHeadersWidth = 51;
            BfoodDataGridView.Size = new Size(450, 672);
            BfoodDataGridView.TabIndex = 12;

            // DataGridView setup (OFooddataGridView)
            OFooddataGridView.Anchor = AnchorStyles.None;
            OFooddataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OFooddataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OFooddataGridView.Columns.AddRange(new DataGridViewColumn[] { FoodName, Quantity, FoodPrice });
            OFooddataGridView.Location = new Point(500, 410);
            OFooddataGridView.Name = "OFooddataGridView";
            OFooddataGridView.RowHeadersWidth = 51;
            OFooddataGridView.Size = new Size(566, 432);
            OFooddataGridView.TabIndex = 15;

            // Buttons setup
            button2.Text = "Back";
            button1.Text = "Search";
            btnOrderFood.Text = "Add Food";
            btnAddFoodInBill.Text = "Add";
            btnCancel.Text = "Cancel";
            btnPrint.Text = "Print";

            // ComboBox setup
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1292, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 41;

            // Finalizing form layout
            Controls.Add(button2);
            Controls.Add(BfoodDataGridView);
            Controls.Add(OFooddataGridView);
            Controls.Add(button1);
            Controls.Add(btnOrderFood);
            Controls.Add(txtQuantity);
            //Controls.Add(txtFoodId);
            Controls.Add(txtMobileNumber);
            Controls.Add(txtuserName);
            Controls.Add(textBox5);
            Controls.Add(btnAddFoodInBill);
            Controls.Add(btnCancel);
            Controls.Add(btnPrint);
            Controls.Add(comboBox1);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView BfoodDataGridView;
        private DataGridViewTextBoxColumn FoodID;
        private DataGridViewTextBoxColumn FoodNameTF;
        private DataGridViewTextBoxColumn FoodPriceTF;
        private DataGridView OFooddataGridView;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn FoodPrice;
        private Button button1;
        private Button btnOrderFood;
        private TextBox txtQuantity;
        private TextBox txtFoodId;
        private TextBox txtMobileNumber;
        private TextBox txtuserName;
        private TextBox textBox5;
        private Button btnAddFoodInBill;
        private Button btnCancel;
        private Button btnPrint;
        private ComboBox comboBox1;
    }
}
