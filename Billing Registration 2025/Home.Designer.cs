namespace Billing_Registration_2025
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            btnLogOut = new Button();
            btnLoans = new Button();
            btntotalOrders = new Button();
            btnDelete = new Button();
            btnUpdatefood = new Button();
            btnAddFood = new Button();
            btnOrderFood = new Button();
            HFoodDataGridView = new DataGridView();
            btnSearchByName = new Button();
            btnSearchByCategory = new Button();
            txtSearchName = new TextBox();
            comboBoxCategoryFilter = new ComboBox();
            btnSearchByPrice = new Button();
            txtSearchPrice = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HFoodDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1482, 125);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(505, 34);
            label1.Name = "label1";
            label1.Size = new Size(566, 46);
            label1.TabIndex = 1;
            label1.Text = "RESTAURANT BILLING SOFTWARE";
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.None;
            btnLogOut.BackColor = Color.MediumSlateBlue;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(21, 799);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(150, 70);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnLoans
            // 
            btnLoans.Anchor = AnchorStyles.None;
            btnLoans.BackColor = Color.MediumSlateBlue;
            btnLoans.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLoans.ForeColor = Color.Black;
            btnLoans.Location = new Point(21, 693);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(150, 70);
            btnLoans.TabIndex = 5;
            btnLoans.Text = "Loans";
            btnLoans.UseVisualStyleBackColor = false;
            // 
            // btntotalOrders
            // 
            btntotalOrders.Anchor = AnchorStyles.None;
            btntotalOrders.BackColor = Color.MediumSlateBlue;
            btntotalOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btntotalOrders.ForeColor = Color.Black;
            btntotalOrders.Location = new Point(21, 585);
            btntotalOrders.Name = "btntotalOrders";
            btntotalOrders.Size = new Size(150, 70);
            btntotalOrders.TabIndex = 4;
            btntotalOrders.Text = "Total Orders";
            btntotalOrders.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.MediumSlateBlue;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(21, 479);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 70);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Food";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdatefood
            // 
            btnUpdatefood.Anchor = AnchorStyles.None;
            btnUpdatefood.BackColor = Color.MediumSlateBlue;
            btnUpdatefood.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdatefood.ForeColor = Color.Black;
            btnUpdatefood.Location = new Point(21, 373);
            btnUpdatefood.Name = "btnUpdatefood";
            btnUpdatefood.Size = new Size(150, 70);
            btnUpdatefood.TabIndex = 2;
            btnUpdatefood.Text = "Update Food";
            btnUpdatefood.UseVisualStyleBackColor = false;
            btnUpdatefood.Click += btnUpdatefood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Anchor = AnchorStyles.None;
            btnAddFood.BackColor = Color.MediumSlateBlue;
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddFood.ForeColor = Color.Black;
            btnAddFood.Location = new Point(21, 257);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(150, 70);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = false;
            // 
            // btnOrderFood
            // 
            btnOrderFood.Anchor = AnchorStyles.None;
            btnOrderFood.BackColor = Color.MediumSlateBlue;
            btnOrderFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOrderFood.ForeColor = Color.Black;
            btnOrderFood.Location = new Point(21, 147);
            btnOrderFood.Name = "btnOrderFood";
            btnOrderFood.Size = new Size(150, 70);
            btnOrderFood.TabIndex = 0;
            btnOrderFood.Text = "Order Food";
            btnOrderFood.UseVisualStyleBackColor = false;
            btnOrderFood.Click += btnOrderFood_Click;
            // 
            // HFoodDataGridView
            // 
            HFoodDataGridView.Anchor = AnchorStyles.None;
            HFoodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HFoodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HFoodDataGridView.Location = new Point(239, 257);
            HFoodDataGridView.Name = "HFoodDataGridView";
            HFoodDataGridView.RowHeadersWidth = 51;
            HFoodDataGridView.Size = new Size(1243, 612);
            HFoodDataGridView.TabIndex = 18;
            // 
            // btnSearchByName
            // 
            btnSearchByName.Anchor = AnchorStyles.None;
            btnSearchByName.BackColor = Color.MediumSlateBlue;
            btnSearchByName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearchByName.ForeColor = Color.Black;
            btnSearchByName.Location = new Point(433, 161);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(176, 45);
            btnSearchByName.TabIndex = 19;
            btnSearchByName.Text = "Search by Name";
            btnSearchByName.UseVisualStyleBackColor = false;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // btnSearchByCategory
            // 
            btnSearchByCategory.Anchor = AnchorStyles.None;
            btnSearchByCategory.BackColor = Color.MediumSlateBlue;
            btnSearchByCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearchByCategory.ForeColor = Color.Black;
            btnSearchByCategory.Location = new Point(867, 161);
            btnSearchByCategory.Name = "btnSearchByCategory";
            btnSearchByCategory.Size = new Size(204, 45);
            btnSearchByCategory.TabIndex = 20;
            btnSearchByCategory.Text = "Search by Category";
            btnSearchByCategory.UseVisualStyleBackColor = false;
            // 
            // txtSearchName
            // 
            txtSearchName.Anchor = AnchorStyles.None;
            txtSearchName.Location = new Point(239, 172);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(188, 27);
            txtSearchName.TabIndex = 21;
            txtSearchName.TextChanged += textBox1_TextChanged;
            // 
            // comboBoxCategoryFilter
            // 
            comboBoxCategoryFilter.Anchor = AnchorStyles.None;
            comboBoxCategoryFilter.FormattingEnabled = true;
            comboBoxCategoryFilter.Location = new Point(665, 173);
            comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            comboBoxCategoryFilter.Size = new Size(196, 28);
            comboBoxCategoryFilter.TabIndex = 22;
            // 
            // btnSearchByPrice
            // 
            btnSearchByPrice.Anchor = AnchorStyles.None;
            btnSearchByPrice.BackColor = Color.MediumSlateBlue;
            btnSearchByPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearchByPrice.ForeColor = Color.Black;
            btnSearchByPrice.Location = new Point(1309, 160);
            btnSearchByPrice.Name = "btnSearchByPrice";
            btnSearchByPrice.Size = new Size(176, 45);
            btnSearchByPrice.TabIndex = 23;
            btnSearchByPrice.Text = "Search by Price";
            btnSearchByPrice.UseVisualStyleBackColor = false;
            // 
            // txtSearchPrice
            // 
            txtSearchPrice.Anchor = AnchorStyles.None;
            txtSearchPrice.Location = new Point(1118, 172);
            txtSearchPrice.Name = "txtSearchPrice";
            txtSearchPrice.Size = new Size(185, 27);
            txtSearchPrice.TabIndex = 24;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1482, 903);
            Controls.Add(txtSearchPrice);
            Controls.Add(btnSearchByPrice);
            Controls.Add(comboBoxCategoryFilter);
            Controls.Add(txtSearchName);
            Controls.Add(btnSearchByCategory);
            Controls.Add(btnSearchByName);
            Controls.Add(HFoodDataGridView);
            Controls.Add(btnLogOut);
            Controls.Add(btnLoans);
            Controls.Add(panel1);
            Controls.Add(btntotalOrders);
            Controls.Add(btnOrderFood);
            Controls.Add(btnDelete);
            Controls.Add(btnAddFood);
            Controls.Add(btnUpdatefood);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HFoodDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogOut;
        private Button btnLoans;
        private Button btntotalOrders;
        private Button btnDelete;
        private Button btnUpdatefood;
        private Button btnAddFood;
        private Button btnOrderFood;
        private DataGridView HFoodDataGridView;
        private Button btnSearchByName;
        private Button btnSearchByCategory;
        private TextBox txtSearchName;
        private ComboBox comboBoxCategoryFilter;
        private Button btnSearchByPrice;
        private TextBox txtSearchPrice;
    }
}