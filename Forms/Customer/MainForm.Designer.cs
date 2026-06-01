namespace SinemaBiletOtomasyonu
{
    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;

       
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pnlHeader = new Panel();
            btnClient = new Button();
            btnAdmin = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(23, 24, 26);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(782, 90);
            label1.TabIndex = 2;
            label1.Text = "🎬 SİNEMA OTOMASYONU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 24, 26);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(782, 90);
            pnlHeader.TabIndex = 4;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.FromArgb(88, 101, 242);
            btnClient.Cursor = Cursors.Hand;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClient.ForeColor = Color.White;
            btnClient.Location = new Point(110, 160);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(260, 220);
            btnClient.TabIndex = 5;
            btnClient.Text = "🍿 Vizyondaki Filmler\r\n\r\nBilet almak ve seansları incelemek için giriş yapın.";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(43, 45, 49);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(88, 101, 242);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(430, 160);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(260, 220);
            btnAdmin.TabIndex = 6;
            btnAdmin.Text = "🛠️ Yönetici Paneli\r\n\r\nFilm, seans ve rezervasyon ayarları için giriş yapın.\r\n";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(782, 453);
            Controls.Add(btnAdmin);
            Controls.Add(btnClient);
            Controls.Add(pnlHeader);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sinema Otomasyonu - Hoş Geldiniz";
            FormClosing += MainForm_FormClosing;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel pnlHeader;
        private Button btnClient;
        private Button btnAdmin;
    }
}
