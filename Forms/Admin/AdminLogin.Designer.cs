namespace SinemaBiletOtomasyonu.Forms.Admin
{
    partial class AdminLogin
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
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 70);
            label1.TabIndex = 0;
            label1.Text = "ADMİN GİRİŞ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(40, 120);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(40, 200);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(50, 52, 55);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(40, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 34);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(50, 52, 55);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(40, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 34);
            txtUsername.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 167, 69);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(382, 403);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici Girişi";
            FormClosed += AdminLogin_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}