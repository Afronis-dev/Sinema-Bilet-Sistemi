namespace SinemaBiletOtomasyonu.Forms.Customer
{
    partial class MovieSelection
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlClientHeader = new Panel();
            lblClientHeaderTitle = new Label();
            flpMovies = new FlowLayoutPanel();
            pnlClientHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientHeader
            // 
            pnlClientHeader.BackColor = Color.FromArgb(23, 24, 26);
            pnlClientHeader.Controls.Add(lblClientHeaderTitle);
            pnlClientHeader.Dock = DockStyle.Top;
            pnlClientHeader.Location = new Point(0, 0);
            pnlClientHeader.Name = "pnlClientHeader";
            pnlClientHeader.Size = new Size(1052, 80);
            pnlClientHeader.TabIndex = 0;
            // 
            // lblClientHeaderTitle
            // 
            lblClientHeaderTitle.Dock = DockStyle.Fill;
            lblClientHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblClientHeaderTitle.ForeColor = Color.White;
            lblClientHeaderTitle.Location = new Point(0, 0);
            lblClientHeaderTitle.Name = "lblClientHeaderTitle";
            lblClientHeaderTitle.Size = new Size(1052, 80);
            lblClientHeaderTitle.TabIndex = 0;
            lblClientHeaderTitle.Text = "🍿 VİZYONDAKİ FİLMLER";
            lblClientHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpMovies
            // 
            flpMovies.AutoScroll = true;
            flpMovies.BackColor = Color.FromArgb(32, 33, 36);
            flpMovies.Dock = DockStyle.Fill;
            flpMovies.Location = new Point(0, 80);
            flpMovies.Name = "flpMovies";
            flpMovies.Padding = new Padding(30, 20, 30, 20);
            flpMovies.Size = new Size(1052, 623);
            flpMovies.TabIndex = 1;
            // 
            // MovieSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1052, 703);
            Controls.Add(flpMovies);
            Controls.Add(pnlClientHeader);
            Name = "MovieSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SİNEMA OTOMASYONU - VİZYONDAKİ FİLMLER";
            FormClosed += MovieSelection_FormClosed;
            Load += MovieSelection_Load;
            pnlClientHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClientHeader;
        private FlowLayoutPanel flpMovies;
        private Label lblClientHeaderTitle;
    }
}