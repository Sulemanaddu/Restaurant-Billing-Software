namespace Billing_Registration_2025
{
    partial class LoginPage
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
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(502, 33);
            label1.Name = "label1";
            label1.Size = new Size(566, 46);
            label1.TabIndex = 1;
            label1.Text = "RESTAURANT BILLING SOFTWARE";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(742, 520);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(218, 28);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click Here to Register";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(611, 520);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 14;
            label5.Text = "New User?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumSlateBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(742, 441);
            button1.Name = "button1";
            button1.Size = new Size(215, 36);
            button1.TabIndex = 13;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(742, 376);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(247, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(742, 311);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 27);
            txtUsername.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(563, 372);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 10;
            label4.Text = "Password:-";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(563, 311);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 9;
            label3.Text = "Username:-";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(856, 217);
            label2.Name = "label2";
            label2.Size = new Size(209, 38);
            label2.TabIndex = 8;
            label2.Text = "ADMIN LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1482, 125);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 778);
            panel2.Name = "panel2";
            panel2.Size = new Size(1482, 125);
            panel2.TabIndex = 17;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1482, 903);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Label label5;
        private Button button1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
    }
}