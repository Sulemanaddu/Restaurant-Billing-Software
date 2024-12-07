namespace Billing_Registration_2025
{
    partial class BillPage
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
            label1 = new Label();
            panel1 = new Panel();
            btnAddFoodCRUD = new Button();
            btnGetDataCURD = new Button();
            btnUpadtefoodCRUD = new Button();
            btnDeleteFoodCRUD = new Button();
            label6 = new Label();
            comboBoxCategory = new ComboBox();
            label5 = new Label();
            txtFoodDescription = new TextBox();
            txtPrice = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtFoodName = new TextBox();
            txtFoodId = new TextBox();
            label2 = new Label();
            label7 = new Label();
            btnBackHome = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 42);
            label1.Name = "label1";
            label1.Size = new Size(503, 41);
            label1.TabIndex = 1;
            label1.Text = "RESTAURANT BILLING SOFTWARE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1482, 125);
            panel1.TabIndex = 2;
            // 
            // btnAddFoodCRUD
            // 
            btnAddFoodCRUD.Anchor = AnchorStyles.None;
            btnAddFoodCRUD.BackColor = Color.MediumSlateBlue;
            btnAddFoodCRUD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFoodCRUD.Location = new Point(413, 554);
            btnAddFoodCRUD.Name = "btnAddFoodCRUD";
            btnAddFoodCRUD.Size = new Size(150, 60);
            btnAddFoodCRUD.TabIndex = 32;
            btnAddFoodCRUD.Text = "ADD FOOD";
            btnAddFoodCRUD.UseVisualStyleBackColor = false;
            btnAddFoodCRUD.Click += btnAddFoodCRUD_Click;
            // 
            // btnGetDataCURD
            // 
            btnGetDataCURD.Anchor = AnchorStyles.None;
            btnGetDataCURD.BackColor = Color.MediumSlateBlue;
            btnGetDataCURD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetDataCURD.Location = new Point(610, 554);
            btnGetDataCURD.Name = "btnGetDataCURD";
            btnGetDataCURD.Size = new Size(151, 58);
            btnGetDataCURD.TabIndex = 31;
            btnGetDataCURD.Text = "GET FOOD";
            btnGetDataCURD.UseVisualStyleBackColor = false;
            btnGetDataCURD.Click += btnGetDataCURD_Click;
            // 
            // btnUpadtefoodCRUD
            // 
            btnUpadtefoodCRUD.Anchor = AnchorStyles.None;
            btnUpadtefoodCRUD.BackColor = Color.MediumSlateBlue;
            btnUpadtefoodCRUD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpadtefoodCRUD.Location = new Point(813, 554);
            btnUpadtefoodCRUD.Name = "btnUpadtefoodCRUD";
            btnUpadtefoodCRUD.Size = new Size(151, 58);
            btnUpadtefoodCRUD.TabIndex = 30;
            btnUpadtefoodCRUD.Text = "UPDATE FOOD";
            btnUpadtefoodCRUD.UseVisualStyleBackColor = false;

            // 
            // btnDeleteFoodCRUD
            // 
            btnDeleteFoodCRUD.Anchor = AnchorStyles.None;
            btnDeleteFoodCRUD.BackColor = Color.MediumSlateBlue;
            btnDeleteFoodCRUD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFoodCRUD.Location = new Point(1017, 554);
            btnDeleteFoodCRUD.Name = "btnDeleteFoodCRUD";
            btnDeleteFoodCRUD.Size = new Size(151, 58);
            btnDeleteFoodCRUD.TabIndex = 29;
            btnDeleteFoodCRUD.Text = "DELETE FOOD";
            btnDeleteFoodCRUD.UseVisualStyleBackColor = false;
            btnDeleteFoodCRUD.Click += btnDeleteFoodCRUD_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(785, 432);
            label6.Name = "label6";
            label6.Size = new Size(163, 32);
            label6.TabIndex = 28;
            label6.Text = "Description:-";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.None;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(990, 301);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(187, 28);
            comboBoxCategory.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(813, 295);
            label5.Name = "label5";
            label5.Size = new Size(135, 32);
            label5.TabIndex = 26;
            label5.Text = "Category:-";
            // 
            // txtFoodDescription
            // 
            txtFoodDescription.Anchor = AnchorStyles.None;
            txtFoodDescription.Location = new Point(990, 432);
            txtFoodDescription.Multiline = true;
            txtFoodDescription.Name = "txtFoodDescription";
            txtFoodDescription.Size = new Size(187, 67);
            txtFoodDescription.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.Location = new Point(519, 465);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(190, 27);
            txtPrice.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(365, 460);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 23;
            label4.Text = "Price:-";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(365, 375);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 22;
            label3.Text = "Name:-";
            // 
            // txtFoodName
            // 
            txtFoodName.Anchor = AnchorStyles.None;
            txtFoodName.Location = new Point(519, 381);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(190, 27);
            txtFoodName.TabIndex = 21;
            // 
            // txtFoodId
            // 
            txtFoodId.Anchor = AnchorStyles.None;
            txtFoodId.Location = new Point(519, 295);
            txtFoodId.Name = "txtFoodId";
            txtFoodId.Size = new Size(190, 27);
            txtFoodId.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(365, 289);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 19;
            label2.Text = "Food Id:-";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline);
            label7.Location = new Point(649, 164);
            label7.Name = "label7";
            label7.Size = new Size(315, 37);
            label7.TabIndex = 33;
            label7.Text = "Add  / Update  / Delete";
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(5, 124);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(94, 29);
            btnBackHome.TabIndex = 34;
            btnBackHome.Text = "back";
            btnBackHome.UseVisualStyleBackColor = true;
            // 
            // AddUpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1482, 903);
            Controls.Add(btnBackHome);
            Controls.Add(label7);
            Controls.Add(btnAddFoodCRUD);
            Controls.Add(btnGetDataCURD);
            Controls.Add(btnUpadtefoodCRUD);
            Controls.Add(btnDeleteFoodCRUD);
            Controls.Add(label6);
            Controls.Add(comboBoxCategory);
            Controls.Add(label5);
            Controls.Add(txtFoodDescription);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodId);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AddUpdateDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUpdateDelete";
            WindowState = FormWindowState.Maximized;
            Load += AddUpdateDelete_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnAddFoodCRUD;
        private Button btnGetDataCURD;
        private Button btnUpadtefoodCRUD;
        private Button btnDeleteFoodCRUD;
        private Label label6;
        private ComboBox comboBoxCategory;
        private Label label5;
        private TextBox txtFoodDescription;
        private TextBox txtPrice;
        private Label label4;
        private Label label3;
        private TextBox txtFoodName;
        private TextBox txtFoodId;
        private Label label2;
        private Label label7;
        private Button btnBackHome;
    }
}