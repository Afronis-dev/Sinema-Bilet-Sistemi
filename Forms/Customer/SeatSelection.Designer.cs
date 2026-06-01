namespace SinemaBiletOtomasyonu.Forms.Customer
{
    partial class SeatSelection
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
            pnlOrderWrapper = new Panel();
            label7 = new Label();
            lblTotalPrice = new Label();
            btnConfirm = new Button();
            pnlBuffet = new Panel();
            numWater = new NumericUpDown();
            label6 = new Label();
            numCoke = new NumericUpDown();
            label5 = new Label();
            numPopcornBig = new NumericUpDown();
            label4 = new Label();
            numPopcornSmall = new NumericUpDown();
            label3 = new Label();
            pnlSelectedSeatsWrapper = new Panel();
            lbSelectedSeats = new ListBox();
            label2 = new Label();
            pnlCinemaRoom = new Panel();
            flpSeats = new FlowLayoutPanel();
            panel1 = new Panel();
            pnlScreen = new Panel();
            label1 = new Label();
            pnlOrderWrapper.SuspendLayout();
            pnlBuffet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPopcornBig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPopcornSmall).BeginInit();
            pnlSelectedSeatsWrapper.SuspendLayout();
            pnlCinemaRoom.SuspendLayout();
            pnlScreen.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOrderWrapper
            // 
            pnlOrderWrapper.BackColor = Color.FromArgb(43, 45, 49);
            pnlOrderWrapper.Controls.Add(label7);
            pnlOrderWrapper.Controls.Add(lblTotalPrice);
            pnlOrderWrapper.Controls.Add(btnConfirm);
            pnlOrderWrapper.Controls.Add(pnlBuffet);
            pnlOrderWrapper.Controls.Add(pnlSelectedSeatsWrapper);
            pnlOrderWrapper.Dock = DockStyle.Right;
            pnlOrderWrapper.Location = new Point(712, 20);
            pnlOrderWrapper.Name = "pnlOrderWrapper";
            pnlOrderWrapper.Padding = new Padding(15);
            pnlOrderWrapper.Size = new Size(320, 563);
            pnlOrderWrapper.TabIndex = 0;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(15, 433);
            label7.Margin = new Padding(3, 0, 3, 5);
            label7.Name = "label7";
            label7.Size = new Size(290, 20);
            label7.TabIndex = 4;
            label7.Text = "Toplam Tutar";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Dock = DockStyle.Bottom;
            lblTotalPrice.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotalPrice.Location = new Point(15, 453);
            lblTotalPrice.Margin = new Padding(3, 0, 3, 5);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(290, 50);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "0.00 TL";
            lblTotalPrice.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnConfirm
            // 
            btnConfirm.AutoSize = true;
            btnConfirm.BackColor = Color.SeaGreen;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Dock = DockStyle.Bottom;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(15, 503);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(290, 45);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "🎟️ SATIN AL / DEVAM ET";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // pnlBuffet
            // 
            pnlBuffet.BackColor = Color.Transparent;
            pnlBuffet.Controls.Add(numWater);
            pnlBuffet.Controls.Add(label6);
            pnlBuffet.Controls.Add(numCoke);
            pnlBuffet.Controls.Add(label5);
            pnlBuffet.Controls.Add(numPopcornBig);
            pnlBuffet.Controls.Add(label4);
            pnlBuffet.Controls.Add(numPopcornSmall);
            pnlBuffet.Controls.Add(label3);
            pnlBuffet.Dock = DockStyle.Top;
            pnlBuffet.Location = new Point(15, 145);
            pnlBuffet.Margin = new Padding(3, 15, 3, 3);
            pnlBuffet.Name = "pnlBuffet";
            pnlBuffet.Size = new Size(290, 180);
            pnlBuffet.TabIndex = 1;
            // 
            // numWater
            // 
            numWater.BackColor = Color.FromArgb(64, 68, 75);
            numWater.BorderStyle = BorderStyle.FixedSingle;
            numWater.ForeColor = Color.White;
            numWater.Location = new Point(210, 130);
            numWater.Name = "numWater";
            numWater.Size = new Size(70, 27);
            numWater.TabIndex = 7;
            numWater.ValueChanged += Buffet_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(3, 130);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 6;
            label6.Text = "💧 Su";
            // 
            // numCoke
            // 
            numCoke.BackColor = Color.FromArgb(64, 68, 75);
            numCoke.BorderStyle = BorderStyle.FixedSingle;
            numCoke.ForeColor = Color.White;
            numCoke.Location = new Point(210, 90);
            numCoke.Name = "numCoke";
            numCoke.Size = new Size(70, 27);
            numCoke.TabIndex = 5;
            numCoke.ValueChanged += Buffet_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(0, 90);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 4;
            label5.Text = "\U0001f964 Kola";
            // 
            // numPopcornBig
            // 
            numPopcornBig.BackColor = Color.FromArgb(64, 68, 75);
            numPopcornBig.BorderStyle = BorderStyle.FixedSingle;
            numPopcornBig.ForeColor = Color.White;
            numPopcornBig.Location = new Point(210, 50);
            numPopcornBig.Name = "numPopcornBig";
            numPopcornBig.Size = new Size(70, 27);
            numPopcornBig.TabIndex = 3;
            numPopcornBig.ValueChanged += Buffet_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(0, 50);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 2;
            label4.Text = "🍿 Mısır (Büyük)";
            // 
            // numPopcornSmall
            // 
            numPopcornSmall.BackColor = Color.FromArgb(64, 68, 75);
            numPopcornSmall.BorderStyle = BorderStyle.FixedSingle;
            numPopcornSmall.ForeColor = Color.White;
            numPopcornSmall.Location = new Point(210, 10);
            numPopcornSmall.Name = "numPopcornSmall";
            numPopcornSmall.Size = new Size(70, 27);
            numPopcornSmall.TabIndex = 1;
            numPopcornSmall.ValueChanged += Buffet_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(0, 10);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 0;
            label3.Text = "🍿 Mısır (Küçük)";
            // 
            // pnlSelectedSeatsWrapper
            // 
            pnlSelectedSeatsWrapper.BackColor = Color.Transparent;
            pnlSelectedSeatsWrapper.Controls.Add(lbSelectedSeats);
            pnlSelectedSeatsWrapper.Controls.Add(label2);
            pnlSelectedSeatsWrapper.Dock = DockStyle.Top;
            pnlSelectedSeatsWrapper.Location = new Point(15, 15);
            pnlSelectedSeatsWrapper.Name = "pnlSelectedSeatsWrapper";
            pnlSelectedSeatsWrapper.Size = new Size(290, 130);
            pnlSelectedSeatsWrapper.TabIndex = 0;
            // 
            // lbSelectedSeats
            // 
            lbSelectedSeats.BackColor = Color.FromArgb(64, 68, 75);
            lbSelectedSeats.BorderStyle = BorderStyle.FixedSingle;
            lbSelectedSeats.Dock = DockStyle.Fill;
            lbSelectedSeats.ForeColor = Color.White;
            lbSelectedSeats.FormattingEnabled = true;
            lbSelectedSeats.Location = new Point(0, 25);
            lbSelectedSeats.Name = "lbSelectedSeats";
            lbSelectedSeats.Size = new Size(290, 105);
            lbSelectedSeats.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(290, 25);
            label2.TabIndex = 0;
            label2.Text = "SEÇİLEN KOLTUKLAR";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCinemaRoom
            // 
            pnlCinemaRoom.Controls.Add(flpSeats);
            pnlCinemaRoom.Controls.Add(panel1);
            pnlCinemaRoom.Controls.Add(pnlScreen);
            pnlCinemaRoom.Dock = DockStyle.Fill;
            pnlCinemaRoom.Location = new Point(20, 20);
            pnlCinemaRoom.Margin = new Padding(3, 3, 20, 3);
            pnlCinemaRoom.Name = "pnlCinemaRoom";
            pnlCinemaRoom.Size = new Size(692, 563);
            pnlCinemaRoom.TabIndex = 1;
            // 
            // flpSeats
            // 
            flpSeats.AutoScroll = true;
            flpSeats.BackColor = Color.FromArgb(23, 24, 26);
            flpSeats.Dock = DockStyle.Fill;
            flpSeats.Location = new Point(0, 54);
            flpSeats.Margin = new Padding(3, 20, 3, 3);
            flpSeats.Name = "flpSeats";
            flpSeats.Padding = new Padding(50);
            flpSeats.Size = new Size(692, 509);
            flpSeats.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(88, 101, 242);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 4);
            panel1.TabIndex = 1;
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = Color.FromArgb(23, 24, 26);
            pnlScreen.Controls.Add(label1);
            pnlScreen.Dock = DockStyle.Top;
            pnlScreen.Location = new Point(0, 0);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(692, 50);
            pnlScreen.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(692, 50);
            label1.TabIndex = 0;
            label1.Text = "S A H N E / P E R D E";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SeatSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1052, 603);
            Controls.Add(pnlCinemaRoom);
            Controls.Add(pnlOrderWrapper);
            Name = "SeatSelection";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sinema Otomasyonu - Koltuk ve Ürün Seçimi";
            FormClosed += SeatSelection_FormClosed;
            Load += SeatSelection_Load;
            pnlOrderWrapper.ResumeLayout(false);
            pnlOrderWrapper.PerformLayout();
            pnlBuffet.ResumeLayout(false);
            pnlBuffet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoke).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPopcornBig).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPopcornSmall).EndInit();
            pnlSelectedSeatsWrapper.ResumeLayout(false);
            pnlCinemaRoom.ResumeLayout(false);
            pnlScreen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOrderWrapper;
        private Panel pnlCinemaRoom;
        private FlowLayoutPanel flpSeats;
        private Panel panel1;
        private Panel pnlScreen;
        private Label label1;
        private Panel pnlSelectedSeatsWrapper;
        private Label label2;
        private Panel pnlBuffet;
        private Label label3;
        private ListBox lbSelectedSeats;
        private NumericUpDown numPopcornSmall;
        private Button btnConfirm;
        private NumericUpDown numWater;
        private Label label6;
        private NumericUpDown numCoke;
        private Label label5;
        private NumericUpDown numPopcornBig;
        private Label label4;
        private Label label7;
        private Label lblTotalPrice;
    }
}