using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.Forms.Admin; // Alt yönetim formlarının klasörü

namespace SinemaBiletOtomasyonu.Forms.Admin
{
    public partial class AdminDashboard : Form
    {
        // Constructor (Yapıcı Metot)
        public AdminDashboard()
        {
            InitializeComponent();

            // Form yüklenirken ve kapanırken çalışacak event'leri bağlıyoruz
            this.Load += new EventHandler(AdminDashboard_Load);
            this.FormClosed += new FormClosedEventHandler(AdminDashboard_FormClosed);

            // Menü butonlarının tıklama olaylarını bağlıyoruz
            btnManageMovies.Click += new EventHandler(btnManageMovies_Click);
            btnViewReservations.Click += new EventHandler(btnViewReservations_Click);
            btnLogOut.Click += new EventHandler(btnLogOut_Click);
            btnManageSessions.Click += new EventHandler(btnManageSessions_Click);
        }

        // Form İlk Açıldığında Çalışacak Kodlar
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Panel açıldığında varsayılan (ilk ekran) olarak Film Yönetimi gelsin
            lblTitle.Text = "Film Yönetimi";
            ShowFormInPanel(new ManageMovies());
        }

        /// <summary>
        /// Sağ taraftaki pnlContent panelinin içerisine dışarıdan gelen formu gömer.
        /// </summary>
        /// <param name="childForm">Panel içine yüklenecek olan Form nesnesi</param>
        private void ShowFormInPanel(Form childForm)
        {
            try
            {
                // 1. Panel içinde halihazırda açık olan eski bir form varsa onu kapat ve temizle
                if (pnlContent.Controls.Count > 0)
                {
                    Form activeForm = pnlContent.Controls[0] as Form;
                    if (activeForm != null)
                    {
                        activeForm.Close(); // Hafıza (RAM) temizliği için önemli
                    }
                    pnlContent.Controls.Clear(); // Paneli boşalt
                }

                // 2. Yeni gelen formu panel içine sığacak bir "Control" bileşeni haline getir
                childForm.TopLevel = false;               // Ayrı bir Windows penceresi olmasını engelle
                childForm.FormBorderStyle = FormBorderStyle.None; // Üst barı, X butonunu ve kenarlıkları yok et
                childForm.Dock = DockStyle.Fill;          // Sağdaki pnlContent panelini tamamen kaplasın

                // 3. Formu panelin kontrollerine ekle ve ekranda göster
                pnlContent.Controls.Add(childForm);
                pnlContent.Tag = childForm;
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alt ekran yüklenirken bir hata oluştu: " + ex.Message,
                                "Panel Hatası",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // 🎬 Film Yönetimi Butonuna Basıldığında
        private void btnManageMovies_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Film Yönetimi";
            ShowFormInPanel(new ManageMovies());
        }

        // 🎟️ Rezervasyonlar Butonuna Basıldığında
        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Rezervasyon Görüntüleme";
            ShowFormInPanel(new ViewReservations());
        }

        // ❌ Çıkış Yap / Kapat Butonuna Basıldığında
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Direkt formu kapatıyoruz. Kapanırken FormClosed olayı tetiklenecek.
            this.Close();
        }

        // Dashboard Kapatıldığında (İster X butonu, ister LogOut butonu ile olsun)
        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Zincirin en başına dönüyoruz: MainForm'u tekrar görünür yap
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

            // Bellek Optimizasyonu: Arka planda gizli (Hide) kalmış olabilecek 
            // tüm AdminLogin veya gereksiz ara pencereleri RAM'den temizleyip kapatıyoruz
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                // Ana giriş formu (MainForm) HARİÇ, açık kalan tüm admin pencerelerini listeye al
                if (f.Name == "AdminLogin" || f.Name == "MovieSelection")
                {
                    openForms.Add(f);
                }
            }

            // Listeye alınan gizli formları tamamen kapat
            foreach (Form f in openForms)
            {
                f.Close();
            }
        }

        private void btnManageSessions_Click(object sender, EventArgs e)
        {
            // Sağdaki pnlContent içerisine ManageSessions formunu gömüyoruz
            ShowFormInPanel(new ManageSessions());

            // Eğer butonların aktifliğini renk değiştirerek belli ediyorsan o kodları da buraya ekleyebilirsin
        }
    }
}