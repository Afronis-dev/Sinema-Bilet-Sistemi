using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.classes; // DatabaseHelper sınıfınızın bulunduğu namespace

namespace SinemaBiletOtomasyonu.Forms.Admin
{
    public partial class ManageSessions : Form
    {
        // Global Değişkenler
        private int selectedSessionID = 0; // Silme veya koltuk listeleme için seçilen Seans ID

        public ManageSessions()
        {
            InitializeComponent();

            // Olayları (Events) Bağlıyoruz
            this.Load += new EventHandler(ManageSessions_Load);
            dgvSessions.CellClick += new DataGridViewCellEventHandler(dgvSessions_CellClick);
            btnSaveSession.Click += new EventHandler(btnSaveSession_Click);
            btnDeleteSession.Click += new EventHandler(btnDeleteSession_Click);
        }

        // --- 1. FORM AÇILIŞI VE ILK YÜKLEMELER ---
        private void ManageSessions_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            RefreshSessionsGrid();
            ResetForm();
        }

        // Formu temizleyen ve seçimleri sıfırlayan yardımcı metot
        private void ResetForm()
        {
            selectedSessionID = 0;
            cmbMovies.SelectedIndex = -1;
            cmbHalls.SelectedIndex = -1;
            dtpSessionDate.Value = DateTime.Now;
            mtxtSessionTime.Text = "12:00";
            numPrice.Value = 150;
            lblSeatsTitle.Text = "Seans Koltuk Önizlemesi (Seçim Yapınız)";
            pnlSeatsGrid.Controls.Clear(); // Koltuk panelini temizle
        }

        // --- 2. COMBOBOX'LARI DOLDURMA (FILM VE SALON LISTESI) ---
        private void LoadComboBoxes()
        {
            try
            {
                // Aktif filmleri ComboBox'a çekiyoruz
                DataTable dtMovies = DatabaseHelper.ExecuteQuery("SELECT MovieID, Title FROM dbo.Movies WHERE IsActive = 1");
                cmbMovies.DataSource = dtMovies;
                cmbMovies.DisplayMember = "Title";
                cmbMovies.ValueMember = "MovieID";
                cmbMovies.SelectedIndex = -1;

                // Salonları ComboBox'a çekiyoruz
                DataTable dtHalls = DatabaseHelper.ExecuteQuery("SELECT HallID, HallName FROM dbo.Halls");
                cmbHalls.DataSource = dtHalls;
                cmbHalls.DisplayMember = "HallName";
                cmbHalls.ValueMember = "HallID";
                cmbHalls.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Açılır listeler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 3. SEANSLARI GRID'DE LISTELEME (READ) ---
        private void RefreshSessionsGrid()
        {
            try
            {
                // İlişkili tabloları JOIN ile bağlayarak seans özetini çekiyoruz
                string query = @"
                    SELECT 
                        s.SessionID AS [Seans ID],
                        m.Title AS [Film Adı],
                        h.HallName AS [Salon],
                        s.SessionDate AS [Tarih],
                        s.SessionTime AS [Saat],
                        s.Price AS [Fiyat]
                    FROM dbo.Sessions s
                    INNER JOIN dbo.Movies m ON s.MovieID = m.MovieID
                    INNER JOIN dbo.Halls h ON s.HallID = h.HallID";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvSessions.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seanslar listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 4. SEANS SEÇILDIGINDE DINAMIK KOLTUK MATRISINI OLUŞTURMA ---
        private void dgvSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSessions.Rows[e.RowIndex];
                selectedSessionID = Convert.ToInt32(row.Cells["Seans ID"].Value);
                string movieTitle = row.Cells["Film Adı"].Value.ToString();
                string hallName = row.Cells["Salon"].Value.ToString();

                lblSeatsTitle.Text = $"{movieTitle} - {hallName} Koltuk Düzeni";

                // Seçilen seansa ait koltuk matrisini sağ panele çiziyoruz
                GenerateSeatMap(selectedSessionID);
            }
        }

        private void GenerateSeatMap(int sessionId)
        {
            // Önce sağ taraftaki panelin içindeki eski butonları tamamen temizliyoruz
            pnlSeatsGrid.Controls.Clear();

            try
            {
                // 1. Adım: Bu seansın oynatıldığı salona ait TÜM KOLTUKLARI veritabanından çekiyoruz
                string seatsQuery = $@"
                    SELECT s.SeatID, s.SeatNumber 
                    FROM dbo.Seats s
                    INNER JOIN dbo.Sessions ss ON s.HallID = ss.HallID
                    WHERE ss.SessionID = {sessionId}";
                DataTable dtSeats = DatabaseHelper.ExecuteQuery(seatsQuery);

                // 2. Adım: Bu seansa ait SATILMIŞ/REZERVASYONLU KOLTUKLARI çekiyoruz
                string reservedQuery = $"SELECT SeatID FROM dbo.Reservations WHERE SessionID = {sessionId}";
                DataTable dtReserved = DatabaseHelper.ExecuteQuery(reservedQuery);

                // Koltukları ekrana grid (matris) düzeninde dizmek için yerleşim değişkenleri
                int xOffset = 15; // Soldan başlangıç boşluğu
                int yOffset = 20; // Üstten başlangıç boşluğu
                int buttonWidth = 45;
                int buttonHeight = 40;
                int margin = 10;  // Butonlar arası boşluk
                int columnsCount = 6; // Yan yana kaç koltuk dizileceği (İsteğe göre değiştirebilirsin)

                for (int i = 0; i < dtSeats.Rows.Count; i++)
                {
                    int seatId = Convert.ToInt32(dtSeats.Rows[i]["SeatID"]);
                    string seatNumber = dtSeats.Rows[i]["SeatNumber"].ToString();

                    // Yeni bir buton (koltuk) oluşturuyoruz
                    Button btnSeat = new Button();
                    btnSeat.Text = seatNumber;
                    btnSeat.Size = new Size(buttonWidth, buttonHeight);
                    btnSeat.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    btnSeat.ForeColor = Color.White;
                    btnSeat.FlatStyle = FlatStyle.Flat;
                    btnSeat.FlatAppearance.BorderSize = 0;

                    // 3. Adım: Koltuk rezervasyonlu mu kontrolü
                    bool isReserved = false;
                    foreach (DataRow rRow in dtReserved.Rows)
                    {
                        if (Convert.ToInt32(rRow["SeatID"]) == seatId)
                        {
                            isReserved = true;
                            break;
                        }
                    }

                    // Duruma göre renk ataması yapıyoruz
                    if (isReserved)
                    {
                        btnSeat.BackColor = Color.Crimson; // Dolu koltuk kırmızı
                        ToolTip tt = new ToolTip();
                        tt.SetToolTip(btnSeat, "Bu koltuk doludur.");
                    }
                    else
                    {
                        btnSeat.BackColor = Color.SeaGreen; // Boş koltuk yeşil
                    }

                    // Matris (Satır/Sütun) koordinat hesaplaması
                    int row = i / columnsCount;
                    int col = i % columnsCount;

                    btnSeat.Location = new Point(
                        xOffset + (col * (buttonWidth + margin)),
                        yOffset + (row * (buttonHeight + margin))
                    );

                    // Oluşturulan dinamik butonu sağ panele ekliyoruz
                    pnlSeatsGrid.Controls.Add(btnSeat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koltuk haritası oluşturulurken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 5. YENI SEANS EKLEME (CREATE) ---
        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedIndex == -1 || cmbHalls.SelectedIndex == -1 || string.IsNullOrWhiteSpace(mtxtSessionTime.Text))
            {
                MessageBox.Show("Lütfen tüm alanları (Film, Salon, Saat) eksiksiz doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int movieId = Convert.ToInt32(cmbMovies.SelectedValue);
                int hallId = Convert.ToInt32(cmbHalls.SelectedValue);
                string sessionDate = dtpSessionDate.Value.ToString("yyyy-MM-dd");
                string sessionTime = mtxtSessionTime.Text.Trim();
                decimal price = numPrice.Value;
                int isActive = 1; // Yeni seans varsayılan aktif

                string query = $@"
                    INSERT INTO dbo.Sessions (MovieID, HallID, SessionDate, SessionTime, Price, IsActive)
                    VALUES ({movieId}, {hallId}, '{sessionDate}', '{sessionTime}', {price.ToString().Replace(",", ".")}, {isActive})";

                DatabaseHelper.ExecuteNonQuery(query);

                MessageBox.Show("Yeni seans başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSessionsGrid();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seans eklenirken hata oluştu: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 6. SEANS SILME (DELETE) ---
        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            if (selectedSessionID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz seansı tablodan seçiniz!", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bu seansı silmek istediğinize emin misiniz?\n(Seansa ait tüm bilet kayıtları da silinebilir!)",
                                                   "Seans Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM dbo.Sessions WHERE SessionID = {selectedSessionID}";
                    DatabaseHelper.ExecuteNonQuery(query);

                    MessageBox.Show("Seans sistemden kalıcı olarak silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSessionsGrid();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seans silinirken hata oluştu (Aktif bilet satışı yapılmış olabilir): " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}