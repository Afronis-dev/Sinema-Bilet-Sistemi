using System;
using System.Data;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.classes; // DatabaseHelper sınıfınızın bulunduğu namespace

namespace SinemaBiletOtomasyonu.Forms.Admin
{
    public partial class ViewReservations : Form
    {
        // Global Değişkenler
        private int selectedTicketID = 0; // İptal işlemi için seçilen ReservationID

        public ViewReservations()
        {
            InitializeComponent();

            // Olayları (Events) Kod Tarafında Bağlıyoruz
            this.Load += new EventHandler(ViewReservations_Load);
            dgvReservations.CellClick += new DataGridViewCellEventHandler(dgvReservations_CellClick);
            txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            btnClearSearch.Click += new EventHandler(btnClearSearch_Click);
            btnCancelReservation.Click += new EventHandler(btnCancelReservation_Click);
        }

        // --- 1. FORM AÇILIŞI ---
        private void ViewReservations_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        // --- 2. VERİLERİ VERİTABANINDAN ÇEKME (INNER JOIN LİSTELEME) ---
        private void LoadReservations(string searchText = "")
        {
            try
            {
                // Tamamen senin şemana göre güncellenmiş SQL Sorgusu:
                // dbo.Seats tablosunu da ekleyerek SeatID üzerinden koltuk adını/numarasını çekiyoruz.
                // NOT: Eğer Seats tablonun içindeki sütun adı "SeatNumber" değilse, "s2.SeatNumber" kısmını "s2.SeatName" vb. yapabilirsin.
                string query = @"
                    SELECT 
                        r.ReservationID AS [Bilet ID],
                        r.CustomerName AS [Müşteri Adı],
                        r.CustomerPhone AS [Telefon],
                        m.Title AS [Film Adı],
                        h.HallName AS [Salon],
                        s2.SeatNumber AS [Koltuk],
                        s.Price AS [Ücret],
                        r.ReservationDate AS [İşlem Tarihi],
                        r.Status AS [Durum]
                    FROM dbo.Reservations r
                    INNER JOIN dbo.Sessions s ON r.SessionID = s.SessionID
                    INNER JOIN dbo.Movies m ON s.MovieID = m.MovieID
                    INNER JOIN dbo.Halls h ON s.HallID = h.HallID
                    INNER JOIN dbo.Seats s2 ON r.SeatID = s2.SeatID
                    WHERE 1=1";

                // Arama filtresini senin sütun isimlerine göre revize ettik
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    string safeSearch = searchText.Replace("'", "''").Trim();
                    query += $" AND (r.CustomerName LIKE '%{safeSearch}%' OR m.Title LIKE '%{safeSearch}%' OR s2.SeatNumber LIKE '%{safeSearch}%')";
                }

                // Sorguyu çalıştırıp Grid'e bağlıyoruz
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvReservations.DataSource = dt;

                // ID sütun genişliğini ayarlayalım
                if (dgvReservations.Columns["Bilet ID"] != null)
                {
                    dgvReservations.Columns["Bilet ID"].Width = 80;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon listesi yüklenirken bir hata oluştu: " + ex.Message,
                                "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 3. ANLIK ARAMA YAPMA (TEXT CHANGED) ---
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadReservations(txtSearch.Text);
        }

        // --- 4. LİSTEYİ YENİLE / TEMİZLE ---
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            selectedTicketID = 0;
            LoadReservations();
        }

        // --- 5. TABLODAN SATIR SEÇİMİ (CELL CLICK) ---
        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReservations.Rows[e.RowIndex];
                // Seçilen satırın Bilet ID'sini hafızaya alıyoruz
                selectedTicketID = Convert.ToInt32(row.Cells["Bilet ID"].Value);
            }
        }

        // --- 6. REZERVASYON İPTAL ETME OPERASYONU (DELETE) ---
        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (selectedTicketID == 0)
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz bilet kaydını tablodan seçiniz!",
                                "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Seçili bilet rezervasyonunu iptal etmek istediğinize emin misiniz?\n(Bu işlem geri alınamaz ve ilgili koltuk boşa çıkacaktır.)",
                                                   "Bilet İptal Onayı",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Şemandaki birincil anahtar ismine (ReservationID) göre silme yapıyoruz
                    string query = $"DELETE FROM dbo.Reservations WHERE ReservationID = {selectedTicketID}";
                    DatabaseHelper.ExecuteNonQuery(query);

                    MessageBox.Show("Bilet rezervasyonu başarıyla iptal edildi.",
                                    "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    selectedTicketID = 0;
                    LoadReservations(txtSearch.Text); // Tabloyu anlık güncelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilet iptal edilirken bir hata meydana geldi: " + ex.Message,
                                    "İptal Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}