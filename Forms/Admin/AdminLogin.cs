using System;
using System.Data;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.classes; // DatabaseHelper sınıfının bulunduğu klasör

namespace SinemaBiletOtomasyonu.Forms.Admin
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

            // Emniyet Kemeri: Formun kapanma olayını kodla bağlıyoruz
            this.FormClosed += new FormClosedEventHandler(AdminLogin_FormClosed);
        }

        // Giriş Yap Butonunun Tıklanma Olayı
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. ADIM: Boşluk Kontrolü (Gereksiz yere veritabanını yormayalım)
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını boş bırakmayınız!",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. ADIM: Temizleme ve Güvenlik (SQL Injection Önlemi)
                string safeUsername = txtUsername.Text.Replace("'", "''").Trim();
                string safePassword = txtPassword.Text.Replace("'", "''").Trim();

                // 3. ADIM: Veritabanı Sorgusu
                // dbo.AdminUsers tablosundaki sütun isimlerinle birebir eşleşiyor
                string query = $"SELECT AdminID, FullName FROM dbo.AdminUsers WHERE Username = '{safeUsername}' AND Password = '{safePassword}'";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                // 4. ADIM: Sonuç Kontrolü
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Giriş başarılı! Kullanıcının tam adını alıyoruz
                    string adminFullName = dt.Rows[0]["FullName"].ToString();

                    MessageBox.Show($"Hoş geldiniz, Sayın {adminFullName}!",
                                    "Giriş Başarılı",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // 5. ADIM: Admin Ana Paneline Geçiş
                    AdminDashboard adminPanel = new AdminDashboard();

                    // MainForm referansını (Owner) yeni açılacak panele paslıyoruz ki zincir kopmasın
                    adminPanel.Owner = this.Owner;

                    adminPanel.Show();

                    // Giriş formuyla işimiz bitti, saklamaya gerek yok; kapatıyoruz.
                    this.Close();
                }
                else
                {
                    // Kullanıcı adı veya şifre eşleşmedi
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz!",
                                    "Erişim Engellendi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    // Şifre kutusunu temizle ve odağı oraya al
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                // Veritabanı bağlantısı koptuğunda veya bir tablo hatasında burası çalışır
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex.Message,
                                "Sistem Hatası",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Form Sağ Üstteki 'X' ile Kapatılırsa Çalışacak Kod
        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Eğer kullanıcı giriş yapmadan pencereyi kapatırsa arkadaki gizli MainForm geri gelsin
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}