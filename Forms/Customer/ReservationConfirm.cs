namespace SinemaBiletOtomasyonu.Forms.Customer
{
    public partial class ReservationConfirm : Form
    {
        public ReservationConfirm()
        {
            InitializeComponent();
        }

        
        public string CustomerName => txtCustomerName.Text;
        public string CustomerEmail => txtCustomerEmail.Text;
        public string CustomerPhone => txtCustomerPhone.Text;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Lütfen geçerli bir isim giriniz. İsim alanı boş bırakılamaz!",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

               
                txtCustomerName.Focus();

                
                return;
            }

           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    } 
}