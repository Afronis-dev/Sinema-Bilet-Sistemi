namespace SinemaBiletOtomasyonu.Forms.Admin
{
    partial class ManageMovies
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlMovieInputs = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            chkIsActive = new CheckBox();
            btnSelectPoster = new Button();
            pbPoster = new PictureBox();
            txtDescription = new TextBox();
            label3 = new Label();
            txtRating = new TextBox();
            label2 = new Label();
            label1 = new Label();
            numDuration = new NumericUpDown();
            cmbGenre = new ComboBox();
            lblGenre = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            pnlGridWrapper = new Panel();
            dgvMovies = new DataGridView();
            pnlMovieInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // pnlMovieInputs
            // 
            pnlMovieInputs.BackColor = Color.FromArgb(43, 45, 49);
            pnlMovieInputs.Controls.Add(btnDelete);
            pnlMovieInputs.Controls.Add(btnUpdate);
            pnlMovieInputs.Controls.Add(btnSave);
            pnlMovieInputs.Controls.Add(chkIsActive);
            pnlMovieInputs.Controls.Add(btnSelectPoster);
            pnlMovieInputs.Controls.Add(pbPoster);
            pnlMovieInputs.Controls.Add(txtDescription);
            pnlMovieInputs.Controls.Add(label3);
            pnlMovieInputs.Controls.Add(txtRating);
            pnlMovieInputs.Controls.Add(label2);
            pnlMovieInputs.Controls.Add(label1);
            pnlMovieInputs.Controls.Add(numDuration);
            pnlMovieInputs.Controls.Add(cmbGenre);
            pnlMovieInputs.Controls.Add(lblGenre);
            pnlMovieInputs.Controls.Add(txtTitle);
            pnlMovieInputs.Controls.Add(lblTitle);
            pnlMovieInputs.Dock = DockStyle.Left;
            pnlMovieInputs.Location = new Point(0, 0);
            pnlMovieInputs.Name = "pnlMovieInputs";
            pnlMovieInputs.Size = new Size(380, 606);
            pnlMovieInputs.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(250, 560);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 40);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(135, 560);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 560);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 40);
            btnSave.TabIndex = 14;
            btnSave.Text = "Ekle";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 11F);
            chkIsActive.ForeColor = Color.White;
            chkIsActive.Location = new Point(20, 500);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(117, 29);
            chkIsActive.TabIndex = 13;
            chkIsActive.Text = "Vizyonda ";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSelectPoster
            // 
            btnSelectPoster.AutoSize = true;
            btnSelectPoster.BackColor = Color.FromArgb(88, 101, 242);
            btnSelectPoster.Cursor = Cursors.Hand;
            btnSelectPoster.FlatAppearance.BorderSize = 0;
            btnSelectPoster.FlatStyle = FlatStyle.Flat;
            btnSelectPoster.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelectPoster.ForeColor = Color.White;
            btnSelectPoster.Location = new Point(160, 400);
            btnSelectPoster.Name = "btnSelectPoster";
            btnSelectPoster.Size = new Size(120, 35);
            btnSelectPoster.TabIndex = 12;
            btnSelectPoster.Text = "Afiş Seç...";
            btnSelectPoster.UseVisualStyleBackColor = false;
            // 
            // pbPoster
            // 
            pbPoster.BorderStyle = BorderStyle.FixedSingle;
            pbPoster.Location = new Point(20, 335);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(120, 160);
            pbPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pbPoster.TabIndex = 11;
            pbPoster.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(64, 68, 75);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(20, 240);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(340, 80);
            txtDescription.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(20, 215);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 9;
            label3.Text = "Film Açıklaması";
            // 
            // txtRating
            // 
            txtRating.BackColor = Color.FromArgb(64, 68, 75);
            txtRating.BorderStyle = BorderStyle.FixedSingle;
            txtRating.Font = new Font("Segoe UI", 11F);
            txtRating.ForeColor = Color.White;
            txtRating.Location = new Point(200, 175);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(160, 32);
            txtRating.TabIndex = 8;
            txtRating.Text = "PG-13";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(200, 150);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 6;
            label2.Text = "Yaş Sınırı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(20, 150);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 5;
            label1.Text = "Süre (Dakika)";
            // 
            // numDuration
            // 
            numDuration.BackColor = Color.FromArgb(64, 68, 75);
            numDuration.BorderStyle = BorderStyle.FixedSingle;
            numDuration.Font = new Font("Segoe UI", 11F);
            numDuration.ForeColor = Color.White;
            numDuration.Location = new Point(20, 175);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(160, 32);
            numDuration.TabIndex = 4;
            numDuration.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // cmbGenre
            // 
            cmbGenre.BackColor = Color.FromArgb(64, 68, 75);
            cmbGenre.FlatStyle = FlatStyle.Flat;
            cmbGenre.Font = new Font("Segoe UI", 11F);
            cmbGenre.ForeColor = Color.White;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Sci-Fi", "Horror", "Animation", "Thriller" });
            cmbGenre.Location = new Point(20, 110);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(340, 33);
            cmbGenre.TabIndex = 3;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 10F);
            lblGenre.ForeColor = Color.LightGray;
            lblGenre.Location = new Point(20, 85);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(81, 23);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Film Türü";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(64, 68, 75);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 11F);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(20, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(340, 32);
            txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.ForeColor = Color.LightGray;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(71, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Film Adı";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvMovies);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(380, 0);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(20);
            pnlGridWrapper.Size = new Size(420, 606);
            pnlGridWrapper.TabIndex = 1;
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.AllowUserToResizeRows = false;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovies.BackgroundColor = Color.FromArgb(32, 33, 36);
            dgvMovies.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 24, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 45, 49);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 101, 242);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMovies.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMovies.Dock = DockStyle.Fill;
            dgvMovies.EnableHeadersVisualStyles = false;
            dgvMovies.GridColor = Color.FromArgb(50, 52, 55);
            dgvMovies.Location = new Point(20, 20);
            dgvMovies.MultiSelect = false;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersVisible = false;
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(380, 566);
            dgvMovies.TabIndex = 0;
            // 
            // ManageMovies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(800, 606);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlMovieInputs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageMovies";
            Text = "ManageMovies";
            pnlMovieInputs.ResumeLayout(false);
            pnlMovieInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMovieInputs;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label label1;
        private NumericUpDown numDuration;
        private ComboBox cmbGenre;
        private Label lblGenre;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtRating;
        private Label label2;
        private PictureBox pbPoster;
        private CheckBox chkIsActive;
        private Button btnSelectPoster;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Panel pnlGridWrapper;
        private DataGridView dgvMovies;
    }
}