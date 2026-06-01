using System;
using System.Data;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.classes; 
using SinemaBiletOtomasyonu.Forms.Customer; 

namespace SinemaBiletOtomasyonu.Forms.Customer
{
    public partial class MovieSelection : Form
    {
        public MovieSelection()
        {
            InitializeComponent();
        }

        private void MovieSelection_Load(object sender, EventArgs e)
        {
            LoadMoviesToUI();
        }

        private void LoadMoviesToUI()
        {
            flpMovies.Controls.Clear();

            try
            {
                string query = "SELECT MovieID, Title, PosterPath FROM Movies WHERE IsActive = 1";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["MovieID"]);
                        string title = row["Title"].ToString();
                        string fileName = row["PosterPath"].ToString();

                        string fullPath = Path.Combine(Application.StartupPath, "Assets", "Images", fileName);

                        MovieCard card = new MovieCard(id, title, fullPath);

                        card.OnSelect += (s, ev) =>
                        {
                            SeatSelection seatForm = new SeatSelection(card.MovieID);
                            if (this.Owner != null)
                            {
                                seatForm.Owner = this.Owner;
                            }
                            seatForm.Show();
                            this.Hide();
                        };

                        flpMovies.Controls.Add(card);
                    }
                }
                else
                {
                    MessageBox.Show("Şu an vizyonda film bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filmler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MovieSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null && !this.Owner.Visible)
            {
                this.Owner.Show();
            }
        }
    }
}