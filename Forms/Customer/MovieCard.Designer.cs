namespace SinemaBiletOtomasyonu.Forms.Customer
{
    partial class MovieCard
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            pbPoster = new PictureBox();
            lblTitle = new Label();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            SuspendLayout();
            // 
            // pbPoster
            // 
            pbPoster.Location = new Point(10, 10);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(200, 240);
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPoster.TabIndex = 0;
            pbPoster.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ImageAlign = ContentAlignment.TopCenter;
            lblTitle.Location = new Point(10, 250);
            lblTitle.Margin = new Padding(3, 15, 3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Film Adı";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Crimson;
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(10, 310);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(200, 40);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Bilet Al";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 49);
            Controls.Add(btnSelect);
            Controls.Add(lblTitle);
            Controls.Add(pbPoster);
            ForeColor = Color.FromArgb(241, 242, 246);
            Margin = new Padding(10);
            Name = "MovieCard";
            Padding = new Padding(3);
            Size = new Size(220, 360);
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbPoster;
        private Label lblTitle;
        private Button btnSelect;
    }
}
