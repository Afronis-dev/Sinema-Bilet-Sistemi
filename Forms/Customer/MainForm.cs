using System;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.Forms.Customer;
using SinemaBiletOtomasyonu.Forms.Admin;

namespace SinemaBiletOtomasyonu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void btnClient_Click(object sender, EventArgs e)
        {
            MovieSelection movieForm = new MovieSelection();
            movieForm.Owner = this;
            movieForm.Show();
            this.Hide();
        }
        
        
       
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin loginForm = new AdminLogin();
            loginForm.Owner = this; 
            loginForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}