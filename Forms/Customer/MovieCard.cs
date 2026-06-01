using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace SinemaBiletOtomasyonu.Forms.Customer
{
    public partial class MovieCard : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MovieID { get; set; }

        public MovieCard()
        {
            InitializeComponent();
        }

        public MovieCard(int id, string title, string imagePath)
        {
            InitializeComponent();
            this.MovieID = id;
            lblTitle.Text = title;

            if (System.IO.File.Exists(imagePath))
            {
                pbPoster.Image = Image.FromFile(imagePath);
            }
            else
            {
                
                MessageBox.Show("Bulunamayan Dosya: " + imagePath); 
                pbPoster.BackColor = Color.Gray;
            }
        }

        public event EventHandler OnSelect;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}