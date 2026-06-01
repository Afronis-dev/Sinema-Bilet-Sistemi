using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SinemaBiletOtomasyonu.Forms.Customer 
{
    public partial class Seat : UserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SeatNumber { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTaken { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSelected { get; set; } = false;

        public event EventHandler StatusChanged;

       
        public Seat()
        {
            InitializeComponent();
        }

        
        public Seat(string seatNumber, bool isTaken) : this()
        {
            this.SeatNumber = seatNumber;
            this.IsTaken = isTaken;

            
            if (lblSeatNumber != null)
            {
                lblSeatNumber.Text = seatNumber;
            }

            UpdateAppearance();
        }

        private void UpdateAppearance()
        {
            if (IsTaken)
            {
                
                this.Enabled = false;

                
                this.BackColor = Color.Red;
                if (lblSeatNumber != null)
                {
                    lblSeatNumber.BackColor = Color.Crimson;
                    lblSeatNumber.ForeColor = Color.White; 
                }
            }
            else
            {
                this.Enabled = true;
                this.BackColor = Color.LightGreen;
                if (lblSeatNumber != null)
                {
                    lblSeatNumber.BackColor = Color.LightGreen;
                    lblSeatNumber.ForeColor = Color.Black;
                }
            }
        }

        
        private void Seat_Click(object sender, EventArgs e)
        {
            if (!IsTaken)
            {
                IsSelected = !IsSelected;
                
                lblSeatNumber.BackColor = IsSelected ? Color.Orange : Color.LightGreen;

                
                StatusChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void lblSeatNumber_Click(object sender, EventArgs e)
        {
            Seat_Click(this, e);
        }
    }
}