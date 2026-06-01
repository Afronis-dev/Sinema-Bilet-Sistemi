namespace SinemaBiletOtomasyonu.Forms.Admin
{
    partial class ViewReservations
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
            pnlFilter = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            btnClearSearch = new Button();
            btnCancelReservation = new Button();
            pnlGridWrapper2 = new Panel();
            dgvReservations = new DataGridView();
            pnlFilter.SuspendLayout();
            pnlGridWrapper2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(43, 45, 49);
            pnlFilter.Controls.Add(btnCancelReservation);
            pnlFilter.Controls.Add(btnClearSearch);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(label1);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1012, 80);
            pnlFilter.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Adı veya Koltuk Ara:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(64, 68, 75);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(240, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 32);
            txtSearch.TabIndex = 1;
            // 
            // btnClearSearch
            // 
            btnClearSearch.AutoSize = true;
            btnClearSearch.BackColor = Color.FromArgb(88, 101, 242);
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Location = new Point(550, 25);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(151, 33);
            btnClearSearch.TabIndex = 2;
            btnClearSearch.Text = "🔄 Listeyi Yenile";
            btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.BackColor = Color.Crimson;
            btnCancelReservation.Cursor = Cursors.Hand;
            btnCancelReservation.FlatAppearance.BorderSize = 0;
            btnCancelReservation.FlatStyle = FlatStyle.Flat;
            btnCancelReservation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelReservation.ForeColor = Color.White;
            btnCancelReservation.Location = new Point(850, 25);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(150, 32);
            btnCancelReservation.TabIndex = 3;
            btnCancelReservation.Text = "🗑️ Bileti İptal Et";
            btnCancelReservation.UseVisualStyleBackColor = false;
            // 
            // pnlGridWrapper2
            // 
            pnlGridWrapper2.Controls.Add(dgvReservations);
            pnlGridWrapper2.Dock = DockStyle.Fill;
            pnlGridWrapper2.Location = new Point(0, 80);
            pnlGridWrapper2.Name = "pnlGridWrapper2";
            pnlGridWrapper2.Padding = new Padding(20);
            pnlGridWrapper2.Size = new Size(1012, 603);
            pnlGridWrapper2.TabIndex = 1;
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.FromArgb(32, 33, 36);
            dgvReservations.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 24, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 45, 49);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 101, 242);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.GridColor = Color.FromArgb(50, 52, 55);
            dgvReservations.Location = new Point(20, 20);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(972, 563);
            dgvReservations.TabIndex = 0;
            // 
            // ViewReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1012, 683);
            Controls.Add(pnlGridWrapper2);
            Controls.Add(pnlFilter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewReservations";
            Text = "ViewReservations";
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlGridWrapper2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFilter;
        private Button btnClearSearch;
        private TextBox txtSearch;
        private Label label1;
        private Button btnCancelReservation;
        private Panel pnlGridWrapper2;
        private DataGridView dgvReservations;
    }
}