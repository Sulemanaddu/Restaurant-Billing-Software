namespace Billing_Registration_2025
{
    partial class AdminRegistration
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
            label8 = new Label();
            label7 = new Label();
            txt_password = new TextBox();
            txt_phone = new TextBox();
            txt_name = new TextBox();
            label5 = new Label();
            txt_Cpass = new TextBox();
            label6 = new Label();
            btn_register = new Button();
            txt_address = new TextBox();
            txt_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            RegLogin = new LinkLabel();
            panel1.SuspendLayout();
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
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(513, 42);
            label1.Name = "label1";
            label1.Size = new Size(566, 46);
            label1.TabIndex = 1;
            label1.Text = "RESTAURANT BILLING SOFTWARE";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(362, 515);
            label8.Name = "label8";
            label8.Size = new Size(139, 32);
            label8.TabIndex = 31;
            label8.Text = "Password:-";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(357, 447);
            label7.Name = "label7";
            label7.Size = new Size(144, 32);
            label7.TabIndex = 30;
            label7.Text = "Phone No:-";
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.None;
            txt_password.Location = new Point(545, 521);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(188, 27);
            txt_password.TabIndex = 29;
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.Location = new Point(545, 452);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(188, 27);
            txt_phone.TabIndex = 28;
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.None;
            txt_name.Location = new Point(545, 381);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(188, 27);
            txt_name.TabIndex = 27;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(403, 381);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 26;
            label5.Text = "Name:-";
            // 
            // txt_Cpass
            // 
            txt_Cpass.Anchor = AnchorStyles.None;
            txt_Cpass.Location = new Point(1017, 542);
            txt_Cpass.Name = "txt_Cpass";
            txt_Cpass.Size = new Size(168, 27);
            txt_Cpass.TabIndex = 25;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(812, 536);
            label6.Name = "label6";
            label6.Size = new Size(180, 32);
            label6.TabIndex = 24;
            label6.Text = "Confirm Pass:-";
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.None;
            btn_register.BackColor = Color.MediumSlateBlue;
            btn_register.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(719, 638);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(215, 36);
            btn_register.TabIndex = 23;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // txt_address
            // 
            txt_address.Anchor = AnchorStyles.None;
            txt_address.Location = new Point(1017, 446);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.PasswordChar = '*';
            txt_address.Size = new Size(168, 63);
            txt_address.TabIndex = 22;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.None;
            txt_username.Location = new Point(1017, 381);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(168, 27);
            txt_username.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(869, 446);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 20;
            label4.Text = "Address:-";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(847, 376);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 19;
            label3.Text = "Username:-";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(639, 231);
            label2.Name = "label2";
            label2.Size = new Size(322, 38);
            label2.TabIndex = 18;
            label2.Text = "ADMIN REGISTRATION";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(667, 771);
            label9.Name = "label9";
            label9.Size = new Size(137, 28);
            label9.TabIndex = 32;
            label9.Text = "Already User ?";
            // 
            // RegLogin
            // 
            RegLogin.Anchor = AnchorStyles.None;
            RegLogin.AutoSize = true;
            RegLogin.Font = new Font("Segoe UI", 12F);
            RegLogin.Location = new Point(847, 771);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(119, 28);
            RegLogin.TabIndex = 33;
            RegLogin.TabStop = true;
            RegLogin.Text = "Login Here!!";
            // 
            // AdminRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1482, 903);
            Controls.Add(RegLogin);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_password);
            Controls.Add(txt_phone);
            Controls.Add(txt_name);
            Controls.Add(label5);
            Controls.Add(txt_Cpass);
            Controls.Add(label6);
            Controls.Add(btn_register);
            Controls.Add(txt_address);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AdminRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminRegistration";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label8;
        private Label label7;
        private TextBox txt_password;
        private TextBox txt_phone;
        private TextBox txt_name;
        private Label label5;
        private TextBox txt_Cpass;
        private Label label6;
        private Button btn_register;
        private TextBox txt_address;
        private TextBox txt_username;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private LinkLabel RegLogin;
    }
}