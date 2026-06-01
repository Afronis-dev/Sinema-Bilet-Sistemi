using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.classes; // DatabaseHelper sınıfınızın bulunduğu namespace

namespace SinemaBiletOtomasyonu.Forms.Admin
{
    public partial class ManageMovies : Form
    {
        // Global Değişkenler
        private string selectedPosterFileName = "default.jpg"; // Seçilen veya mevcut afiş adını tutar
        private int selectedMovieID = 0; // Güncelleme ve silme işlemleri için seçilen filmin ID'si

        public ManageMovies()
        {
            InitializeComponent();

            // Form Olaylarını (Events) Kod Tarafında Bağlıyoruz
            this.Load += new EventHandler(ManageMovies_Load);
            dgvMovies.CellClick += new DataGridViewCellEventHandler(dgvMovies_CellClick);
            btnSelectPoster.Click += new EventHandler(btnSelectPoster_Click);
            btnSave.Click += new EventHandler(btnSave_Click);
            btnUpdate.Click += new EventHandler(btnUpdate_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
        }

        // --- 1. FORM AÇILIŞI VE TEMİZLİK ---
        private void ManageMovies_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearForm();
        }

        // Giriş kutularını ve seçimleri sıfırlayan yardımcı metot
        private void ClearForm()
        {
            selectedMovieID = 0;
            txtTitle.Clear();
            cmbGenre.SelectedIndex = -1; // Seçimi temizle
            numDuration.Value = 120; // Varsayılan 2 saat
            txtRating.Text = "PG-13";
            txtDescription.Clear();
            chkIsActive.Checked = true;

            if (pbPoster.Image != null)
            {
                pbPoster.Image.Dispose(); // Önceki resmi hafızadan at
                pbPoster.Image = null;
            }
            selectedPosterFileName = "default.jpg";
        }

        // --- 2. VERİ LİSTELEME (READ) ---
        private void RefreshGrid()
        {
            try
            {
                // Movies tablosundaki verileri seçiyoruz
                string query = "SELECT MovieID, Title, Genre, Duration, Rating, Description, PosterPath, IsActive FROM dbo.Movies";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dgvMovies.DataSource = dt;

                // Sütun başlıklarını kullanıcı dostu yapalım
                if (dgvMovies.Columns["MovieID"] != null) dgvMovies.Columns["MovieID"].HeaderText = "ID";
                if (dgvMovies.Columns["Title"] != null) dgvMovies.Columns["Title"].HeaderText = "Film Adı";
                if (dgvMovies.Columns["Genre"] != null) dgvMovies.Columns["Genre"].HeaderText = "Tür";
                if (dgvMovies.Columns["Duration"] != null) dgvMovies.Columns["Duration"].HeaderText = "Süre (Dk)";
                if (dgvMovies.Columns["Rating"] != null) dgvMovies.Columns["Rating"].HeaderText = "Rating";
                if (dgvMovies.Columns["Description"] != null) dgvMovies.Columns["Description"].HeaderText = "Açıklama";
                if (dgvMovies.Columns["IsActive"] != null) dgvMovies.Columns["IsActive"].HeaderText = "Aktif mi?";

                // Poster dosya yolunu tabloda göstermeye gerek yok, gizliyoruz
                if (dgvMovies.Columns["PosterPath"] != null) dgvMovies.Columns["PosterPath"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filmler listelenirken bir hata oluştu: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 3. TABLODAN SATIR SEÇİMİ (CELL CLICK) ---
        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan satır başlık satırı değilse (-1 kontrolü)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMovies.Rows[e.RowIndex];

                // Seçilen satırın verilerini değişkenlere ve kontrollere aktar
                selectedMovieID = Convert.ToInt32(row.Cells["MovieID"].Value);
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                cmbGenre.Text = row.Cells["Genre"].Value.ToString();
                numDuration.Value = Convert.ToInt32(row.Cells["Duration"].Value);
                txtRating.Text = row.Cells["Rating"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                selectedPosterFileName = row.Cells["PosterPath"].Value.ToString();

                // Resmi PictureBox'a güvenli yükleme işlemi (Hafızada kilit kalmaması için)
                string posterFullPath = Path.Combine(Application.StartupPath, "Assets", "Images", selectedPosterFileName);

                if (pbPoster.Image != null) pbPoster.Image.Dispose(); // Eski resmi temizle

                if (File.Exists(posterFullPath))
                {
                    // FileStream kullanarak resmi açıyoruz, böylece Windows dosyayı kilitlemez ve resim silinebilir/değiştirilebilir kalır
                    using (FileStream fs = new FileStream(posterFullPath, FileMode.Open, FileAccess.Read))
                    {
                        pbPoster.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    pbPoster.Image = null; // Klasörde afiş yoksa boş göster
                }
            }
        }

        // --- 4. AFİŞ / POSTER SEÇME İŞLEMİ ---
        private void btnSelectPoster_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Title = "Film Afişi Seçiniz";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Projenin derlendiği yerdeki Assets/Images klasör yolunu hazırla
                        string targetFolder = Path.Combine(Application.StartupPath, "Assets", "Images");
                        if (!Directory.Exists(targetFolder))
                        {
                            Directory.CreateDirectory(targetFolder);
                        }

                        // Aynı isimde resimlerin çakışmaması için benzersiz bir Guid dosya adı üretelim
                        string extension = Path.GetExtension(ofd.FileName);
                        selectedPosterFileName = Guid.NewGuid().ToString() + extension;

                        string targetPath = Path.Combine(targetFolder, selectedPosterFileName);

                        // Resmi hedef klasörümüze kopyala
                        File.Copy(ofd.FileName, targetPath, true);

                        // PictureBox önizlemesini güncelle
                        if (pbPoster.Image != null) pbPoster.Image.Dispose();
                        using (FileStream fs = new FileStream(targetPath, FileMode.Open, FileAccess.Read))
                        {
                            pbPoster.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // --- 5. FİLM EKLEME (CREATE) ---
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Lütfen en azından bir Film Adı giriniz!", "Eksik Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string safeTitle = txtTitle.Text.Replace("'", "''").Trim();
                string safeDescription = txtDescription.Text.Replace("'", "''").Trim();
                int isActiveVal = chkIsActive.Checked ? 1 : 0;
                string todayStr = DateTime.Now.ToString("yyyy-MM-dd");

                string query = $@"INSERT INTO dbo.Movies (Title, Genre, Duration, Rating, Description, ReleaseDate, PosterPath, IsActive) 
                                 VALUES ('{safeTitle}', '{cmbGenre.Text}', {numDuration.Value}, '{txtRating.Text}', '{safeDescription}', '{todayStr}', '{selectedPosterFileName}', {isActiveVal})";

                DatabaseHelper.ExecuteNonQuery(query);

                MessageBox.Show($"{safeTitle} filmi başarıyla sisteme eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film eklenirken veritabanı hatası oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 6. FİLM GÜNCELLEME (UPDATE) ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMovieID == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz filmi sağdaki tablodan seçiniz!", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string safeTitle = txtTitle.Text.Replace("'", "''").Trim();
                string safeDescription = txtDescription.Text.Replace("'", "''").Trim();
                int isActiveVal = chkIsActive.Checked ? 1 : 0;

                string query = $@"UPDATE dbo.Movies SET 
                                 Title = '{safeTitle}', 
                                 Genre = '{cmbGenre.Text}', 
                                 Duration = {numDuration.Value}, 
                                 Rating = '{txtRating.Text}', 
                                 Description = '{safeDescription}', 
                                 PosterPath = '{selectedPosterFileName}', 
                                 IsActive = {isActiveVal} 
                                 WHERE MovieID = {selectedMovieID}";

                DatabaseHelper.ExecuteNonQuery(query);

                MessageBox.Show("Film bilgileri başarıyla güncellendi.", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 7. FİLM SİLME (DELETE) ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMovieID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz filmi sağdaki tablodan seçiniz!", "Seçim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Seçili filmi sistemden tamamen silmek istediğinize emin misiniz?\n(Bu filme ait eski seanslar ve biletler etkilenebilir!)",
                                                   "Kayıt Silme Onayı",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM dbo.Movies WHERE MovieID = {selectedMovieID}";
                    DatabaseHelper.ExecuteNonQuery(query);

                    MessageBox.Show("Film sistemden kalıcı olarak silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Film silinirken bir hata oluştu (Yabancıl anahtar kısıtlaması olabilir): " + ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}