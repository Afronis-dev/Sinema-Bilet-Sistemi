namespace SinemaBiletOtomasyonu.Forms.Customer
{
    partial class ReservationConfirm
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
            pnlPopHeader = new Panel();
            label1 = new Label();
            pnlFields = new Panel();
            pnlPopFooter = new Panel();
            btnCancel = new Button();
            btnConfirm = new Button();
            panel3 = new Panel();
            txtCustomerPhone = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            txtCustomerEmail = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtCustomerName = new TextBox();
            label2 = new Label();
            pnlPopHeader.SuspendLayout();
            pnlFields.SuspendLayout();
            pnlPopFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPopHeader
            // 
            pnlPopHeader.BackColor = Color.FromArgb(23, 24, 26);
            pnlPopHeader.Controls.Add(label1);
            pnlPopHeader.Dock = DockStyle.Top;
            pnlPopHeader.Location = new Point(0, 0);
            pnlPopHeader.Name = "pnlPopHeader";
            pnlPopHeader.Size = new Size(420, 70);
            pnlPopHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(420, 70);
            label1.TabIndex = 0;
            label1.Text = "👤 MÜŞTERİ BİLGİLERİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFields
            // 
            pnlFields.BackColor = Color.Transparent;
            pnlFields.Controls.Add(pnlPopFooter);
            pnlFields.Controls.Add(panel3);
            pnlFields.Controls.Add(txtCustomerPhone);
            pnlFields.Controls.Add(label4);
            pnlFields.Controls.Add(panel2);
            pnlFields.Controls.Add(txtCustomerEmail);
            pnlFields.Controls.Add(label3);
            pnlFields.Controls.Add(panel1);
            pnlFields.Controls.Add(txtCustomerName);
            pnlFields.Controls.Add(label2);
            pnlFields.Dock = DockStyle.Fill;
            pnlFields.Location = new Point(0, 70);
            pnlFields.Name = "pnlFields";
            pnlFields.Padding = new Padding(10, 25, 10, 25);
            pnlFields.Size = new Size(420, 450);
            pnlFields.TabIndex = 1;
            // 
            // pnlPopFooter
            // 
            pnlPopFooter.BackColor = Color.Transparent;
            pnlPopFooter.Controls.Add(btnCancel);
            pnlPopFooter.Controls.Add(btnConfirm);
            pnlPopFooter.Dock = DockStyle.Bottom;
            pnlPopFooter.Location = new Point(10, 320);
            pnlPopFooter.Name = "pnlPopFooter";
            pnlPopFooter.Size = new Size(400, 105);
            pnlPopFooter.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(43, 45, 49);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(64, 68, 75);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.DarkGray;
            btnCancel.Location = new Point(0, 52);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(400, 53);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SeaGreen;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Dock = DockStyle.Top;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(0, 0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(400, 52);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "🎟️ BİLETİ ONAYLA";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 15);
            panel3.TabIndex = 8;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.BackColor = Color.FromArgb(64, 68, 75);
            txtCustomerPhone.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerPhone.Dock = DockStyle.Top;
            txtCustomerPhone.Font = new Font("Segoe UI", 11F);
            txtCustomerPhone.ForeColor = Color.White;
            txtCustomerPhone.Location = new Point(10, 185);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(400, 32);
            txtCustomerPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(10, 163);
            label4.Name = "label4";
            label4.Size = new Size(400, 22);
            label4.TabIndex = 6;
            label4.Text = "Telefon No";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 15);
            panel2.TabIndex = 5;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.BackColor = Color.FromArgb(64, 68, 75);
            txtCustomerEmail.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerEmail.Dock = DockStyle.Top;
            txtCustomerEmail.Font = new Font("Segoe UI", 11F);
            txtCustomerEmail.ForeColor = Color.White;
            txtCustomerEmail.Location = new Point(10, 116);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(400, 32);
            txtCustomerEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(10, 94);
            label3.Name = "label3";
            label3.Size = new Size(400, 22);
            label3.TabIndex = 3;
            label3.Text = "E-Posta Adresi";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 15);
            panel1.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.FromArgb(64, 68, 75);
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Dock = DockStyle.Top;
            txtCustomerName.Font = new Font("Segoe UI", 11F);
            txtCustomerName.ForeColor = Color.White;
            txtCustomerName.Location = new Point(10, 47);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(400, 32);
            txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(10, 25);
            label2.Name = "label2";
            label2.Size = new Size(400, 22);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad";
            // 
            // ReservationConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(420, 520);
            Controls.Add(pnlFields);
            Controls.Add(pnlPopHeader);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservationConfirm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rezervasyon Onayı";
            pnlPopHeader.ResumeLayout(false);
            pnlFields.ResumeLayout(false);
            pnlFields.PerformLayout();
            pnlPopFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPopHeader;
        private Label label1;
        private Panel pnlFields;
        private Panel panel3;
        private TextBox txtCustomerPhone;
        private Label label4;
        private Panel panel2;
        private TextBox txtCustomerEmail;
        private Label label3;
        private Panel panel1;
        private TextBox txtCustomerName;
        private Label label2;
        private Panel pnlPopFooter;
        private Button btnCancel;
        private Button btnConfirm;
    }
}