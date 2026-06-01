namespace SinemaBiletOtomasyonu.Forms.Customer
{
    partial class Seat
    {
      

       
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
            lblSeatNumber = new Label();
            SuspendLayout();
            // 
            // lblSeatNumber
            // 
            lblSeatNumber.BackColor = Color.LightGreen;
            lblSeatNumber.Dock = DockStyle.Fill;
            lblSeatNumber.Location = new Point(0, 0);
            lblSeatNumber.Name = "lblSeatNumber";
            lblSeatNumber.Size = new Size(50, 50);
            lblSeatNumber.TabIndex = 0;
            lblSeatNumber.Text = "label1";
            lblSeatNumber.TextAlign = ContentAlignment.MiddleCenter;
            lblSeatNumber.Click += lblSeatNumber_Click;
            // 
            // Seat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSeatNumber);
            Margin = new Padding(4);
            Name = "Seat";
            Size = new Size(50, 50);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSeatNumber;
    }
}
