namespace SinemaBiletOtomasyonu.Forms.Admin
{
    partial class ManageSessions
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvSessions = new DataGridView();
            btnSaveSession = new Button();
            btnDeleteSession = new Button();
            numPrice = new NumericUpDown();
            label5 = new Label();
            mtxtSessionTime = new MaskedTextBox();
            label4 = new Label();
            dtpSessionDate = new DateTimePicker();
            label3 = new Label();
            cmbMovies = new ComboBox();
            cmbHalls = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pnlSeatsWrapper = new Panel();
            pnlSeatsGrid = new Panel();
            lblSeatsTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            pnlSeatsWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 49);
            panel1.Controls.Add(dgvSessions);
            panel1.Controls.Add(btnSaveSession);
            panel1.Controls.Add(btnDeleteSession);
            panel1.Controls.Add(numPrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(mtxtSessionTime);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpSessionDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbMovies);
            panel1.Controls.Add(cmbHalls);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 730);
            panel1.TabIndex = 0;
            // 
            // dgvSessions
            // 
            dgvSessions.AllowUserToAddRows = false;
            dgvSessions.AllowUserToDeleteRows = false;
            dgvSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSessions.BackgroundColor = Color.FromArgb(32, 33, 36);
            dgvSessions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(23, 24, 26);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 68, 75);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(88, 101, 242);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSessions.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSessions.EnableHeadersVisualStyles = false;
            dgvSessions.GridColor = Color.FromArgb(50, 52, 55);
            dgvSessions.Location = new Point(20, 230);
            dgvSessions.MultiSelect = false;
            dgvSessions.Name = "dgvSessions";
            dgvSessions.ReadOnly = true;
            dgvSessions.RowHeadersVisible = false;
            dgvSessions.RowHeadersWidth = 51;
            dgvSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSessions.Size = new Size(500, 460);
            dgvSessions.TabIndex = 13;
            // 
            // btnSaveSession
            // 
            btnSaveSession.BackColor = Color.SeaGreen;
            btnSaveSession.Cursor = Cursors.Hand;
            btnSaveSession.FlatAppearance.BorderSize = 0;
            btnSaveSession.FlatStyle = FlatStyle.Flat;
            btnSaveSession.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveSession.ForeColor = Color.White;
            btnSaveSession.Location = new Point(20, 165);
            btnSaveSession.Name = "btnSaveSession";
            btnSaveSession.Size = new Size(240, 38);
            btnSaveSession.TabIndex = 12;
            btnSaveSession.Text = "Seans Ekle";
            btnSaveSession.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSession
            // 
            btnDeleteSession.BackColor = Color.Crimson;
            btnDeleteSession.Cursor = Cursors.Hand;
            btnDeleteSession.FlatAppearance.BorderSize = 0;
            btnDeleteSession.FlatStyle = FlatStyle.Flat;
            btnDeleteSession.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteSession.ForeColor = Color.White;
            btnDeleteSession.Location = new Point(280, 165);
            btnDeleteSession.Name = "btnDeleteSession";
            btnDeleteSession.Size = new Size(240, 38);
            btnDeleteSession.TabIndex = 11;
            btnDeleteSession.Text = "Seans Sil";
            btnDeleteSession.UseVisualStyleBackColor = false;
            // 
            // numPrice
            // 
            numPrice.BackColor = Color.FromArgb(64, 68, 75);
            numPrice.BorderStyle = BorderStyle.FixedSingle;
            numPrice.ForeColor = Color.White;
            numPrice.Location = new Point(410, 115);
            numPrice.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(110, 27);
            numPrice.TabIndex = 10;
            numPrice.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(410, 90);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 9;
            label5.Text = "Fiyat (TL)";
            // 
            // mtxtSessionTime
            // 
            mtxtSessionTime.BackColor = Color.FromArgb(64, 68, 75);
            mtxtSessionTime.BorderStyle = BorderStyle.FixedSingle;
            mtxtSessionTime.ForeColor = Color.White;
            mtxtSessionTime.Location = new Point(280, 115);
            mtxtSessionTime.Mask = "00:00";
            mtxtSessionTime.Name = "mtxtSessionTime";
            mtxtSessionTime.Size = new Size(110, 27);
            mtxtSessionTime.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(280, 90);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 7;
            label4.Text = "Seans Saati (ss:dd)";
            // 
            // dtpSessionDate
            // 
            dtpSessionDate.Format = DateTimePickerFormat.Short;
            dtpSessionDate.Location = new Point(20, 115);
            dtpSessionDate.Name = "dtpSessionDate";
            dtpSessionDate.Size = new Size(240, 27);
            dtpSessionDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Seans Tarihi";
            // 
            // cmbMovies
            // 
            cmbMovies.BackColor = Color.FromArgb(64, 68, 75);
            cmbMovies.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovies.FlatStyle = FlatStyle.Flat;
            cmbMovies.ForeColor = Color.White;
            cmbMovies.FormattingEnabled = true;
            cmbMovies.Location = new Point(20, 45);
            cmbMovies.Name = "cmbMovies";
            cmbMovies.Size = new Size(240, 28);
            cmbMovies.TabIndex = 4;
            // 
            // cmbHalls
            // 
            cmbHalls.BackColor = Color.FromArgb(64, 68, 75);
            cmbHalls.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHalls.FlatStyle = FlatStyle.Flat;
            cmbHalls.ForeColor = Color.White;
            cmbHalls.FormattingEnabled = true;
            cmbHalls.Location = new Point(280, 45);
            cmbHalls.Name = "cmbHalls";
            cmbHalls.Size = new Size(240, 28);
            cmbHalls.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(280, 20);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Salon Seçiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Film Seçiniz";
            // 
            // pnlSeatsWrapper
            // 
            pnlSeatsWrapper.Controls.Add(pnlSeatsGrid);
            pnlSeatsWrapper.Controls.Add(lblSeatsTitle);
            pnlSeatsWrapper.Dock = DockStyle.Fill;
            pnlSeatsWrapper.Location = new Point(550, 0);
            pnlSeatsWrapper.Name = "pnlSeatsWrapper";
            pnlSeatsWrapper.Padding = new Padding(25);
            pnlSeatsWrapper.Size = new Size(480, 730);
            pnlSeatsWrapper.TabIndex = 1;
            // 
            // pnlSeatsGrid
            // 
            pnlSeatsGrid.BackColor = Color.FromArgb(23, 24, 26);
            pnlSeatsGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlSeatsGrid.Dock = DockStyle.Fill;
            pnlSeatsGrid.Location = new Point(25, 53);
            pnlSeatsGrid.Name = "pnlSeatsGrid";
            pnlSeatsGrid.Size = new Size(430, 652);
            pnlSeatsGrid.TabIndex = 1;
            // 
            // lblSeatsTitle
            // 
            lblSeatsTitle.Dock = DockStyle.Top;
            lblSeatsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeatsTitle.ForeColor = Color.White;
            lblSeatsTitle.Location = new Point(25, 25);
            lblSeatsTitle.Name = "lblSeatsTitle";
            lblSeatsTitle.Size = new Size(430, 28);
            lblSeatsTitle.TabIndex = 0;
            lblSeatsTitle.Text = "Seans Koltuk Önizlemesi";
            lblSeatsTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // ManageSessions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1030, 730);
            Controls.Add(pnlSeatsWrapper);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageSessions";
            Text = "ManageSessions";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            pnlSeatsWrapper.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox cmbMovies;
        private ComboBox cmbHalls;
        private Label label2;
        private Label label1;
        private NumericUpDown numPrice;
        private Label label5;
        private MaskedTextBox mtxtSessionTime;
        private Label label4;
        private DateTimePicker dtpSessionDate;
        private DataGridView dgvSessions;
        private Button btnSaveSession;
        private Button btnDeleteSession;
        private Panel pnlSeatsWrapper;
        private Panel pnlSeatsGrid;
        private Label lblSeatsTitle;
    }
}