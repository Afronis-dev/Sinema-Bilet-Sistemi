namespace SinemaBiletOtomasyonu.Forms.Admin
{
    partial class AdminDashboard
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
            pnlSidebar = new Panel();
            btnLogOut = new Button();
            btnManageSessions = new Button();
            btnViewReservations = new Button();
            btnManageMovies = new Button();
            pnlLogo = new Panel();
            label1 = new Label();
            pnlHeader = new Panel();
            lblAdminName = new Label();
            lblTitle = new Label();
            pnlHeaderDivider = new Panel();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(23, 24, 26);
            pnlSidebar.Controls.Add(btnLogOut);
            pnlSidebar.Controls.Add(btnManageSessions);
            pnlSidebar.Controls.Add(btnViewReservations);
            pnlSidebar.Controls.Add(btnManageMovies);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 753);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(192, 0, 0);
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(0, 693);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(250, 60);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Kapat / Çıkış";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnManageSessions
            // 
            btnManageSessions.Dock = DockStyle.Top;
            btnManageSessions.FlatAppearance.BorderSize = 0;
            btnManageSessions.FlatStyle = FlatStyle.Flat;
            btnManageSessions.Font = new Font("Segoe UI", 11F);
            btnManageSessions.ForeColor = Color.Gainsboro;
            btnManageSessions.Location = new Point(0, 220);
            btnManageSessions.Name = "btnManageSessions";
            btnManageSessions.Padding = new Padding(20, 0, 0, 0);
            btnManageSessions.Size = new Size(250, 60);
            btnManageSessions.TabIndex = 3;
            btnManageSessions.Text = "🎬 Seans Yönetimi";
            btnManageSessions.TextAlign = ContentAlignment.MiddleLeft;
            btnManageSessions.UseVisualStyleBackColor = true;
            btnManageSessions.Click += btnManageSessions_Click;
            // 
            // btnViewReservations
            // 
            btnViewReservations.Dock = DockStyle.Top;
            btnViewReservations.FlatAppearance.BorderSize = 0;
            btnViewReservations.FlatStyle = FlatStyle.Flat;
            btnViewReservations.Font = new Font("Segoe UI", 11F);
            btnViewReservations.ForeColor = Color.Gainsboro;
            btnViewReservations.Location = new Point(0, 160);
            btnViewReservations.Name = "btnViewReservations";
            btnViewReservations.Padding = new Padding(20, 0, 0, 0);
            btnViewReservations.Size = new Size(250, 60);
            btnViewReservations.TabIndex = 2;
            btnViewReservations.Text = "🎟️  Rezervasyonlar";
            btnViewReservations.TextAlign = ContentAlignment.MiddleLeft;
            btnViewReservations.UseVisualStyleBackColor = true;
            // 
            // btnManageMovies
            // 
            btnManageMovies.Dock = DockStyle.Top;
            btnManageMovies.FlatAppearance.BorderSize = 0;
            btnManageMovies.FlatStyle = FlatStyle.Flat;
            btnManageMovies.Font = new Font("Segoe UI", 11F);
            btnManageMovies.ForeColor = Color.Gainsboro;
            btnManageMovies.Location = new Point(0, 100);
            btnManageMovies.Name = "btnManageMovies";
            btnManageMovies.Padding = new Padding(20, 0, 0, 0);
            btnManageMovies.Size = new Size(250, 60);
            btnManageMovies.TabIndex = 1;
            btnManageMovies.Text = "🎬  Film Yönetimi";
            btnManageMovies.TextAlign = ContentAlignment.MiddleLeft;
            btnManageMovies.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(label1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 100);
            pnlLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 100);
            label1.TabIndex = 0;
            label1.Text = "YÖNETİCİ PANELİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblAdminName);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlHeaderDivider);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1012, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblAdminName
            // 
            lblAdminName.Dock = DockStyle.Right;
            lblAdminName.Font = new Font("Segoe UI", 10F);
            lblAdminName.ForeColor = Color.DarkGray;
            lblAdminName.Location = new Point(848, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(164, 69);
            lblAdminName.TabIndex = 2;
            lblAdminName.Text = "Hoş Geldiniz, Admin";
            lblAdminName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 69);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Panel Önizleme";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeaderDivider
            // 
            pnlHeaderDivider.BackColor = Color.FromArgb(45, 45, 48);
            pnlHeaderDivider.Dock = DockStyle.Bottom;
            pnlHeaderDivider.Location = new Point(0, 69);
            pnlHeaderDivider.Name = "pnlHeaderDivider";
            pnlHeaderDivider.Size = new Size(1012, 1);
            pnlHeaderDivider.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(250, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1012, 683);
            pnlContent.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1262, 753);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetim Konsolu";
            pnlSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnManageSessions;
        private Button btnViewReservations;
        private Button btnManageMovies;
        private Panel pnlLogo;
        private Label label1;
        private Button btnLogOut;
        private Panel pnlHeader;
        private Label lblAdminName;
        private Label lblTitle;
        private Panel pnlHeaderDivider;
        private Panel pnlContent;
    }
}