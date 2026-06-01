using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SinemaBiletOtomasyonu.classes;

namespace SinemaBiletOtomasyonu.Forms.Customer
{
    public partial class SeatSelection : Form
    {
        private int _movieID;
        private int _sessionID;
        private List<int> selectedSeatIDs = new List<int>();

        private Dictionary<string, decimal> prices = new Dictionary<string, decimal>
        {
            { "Ticket", 150m },
            { "PopcornS", 80m },
            { "PopcornB", 120m },
            { "Coke", 50m },
            { "Water", 20m }
        };

        public SeatSelection(int movieID)
        {
            InitializeComponent();
            this._movieID = movieID;

           
            this.Load += new EventHandler(SeatSelection_Load);
        }

        private void SeatSelection_Load(object sender, EventArgs e)
        {
           
            string sessionQuery = $"SELECT TOP 1 SessionID, Price FROM dbo.Sessions WHERE MovieID = {_movieID} AND IsActive = 1";
            DataTable dtSession = DatabaseHelper.ExecuteQuery(sessionQuery);

            if (dtSession != null && dtSession.Rows.Count > 0)
            {
                _sessionID = Convert.ToInt32(dtSession.Rows[0]["SessionID"]);
                LoadSeats();
            }
            else
            {
                MessageBox.Show("Bu film için aktif bir seans bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadSeats()
        {
            flpSeats.Controls.Clear();

           
            string reservedQuery = $"SELECT SeatID FROM dbo.Reservations WHERE SessionID = {_sessionID}";
            DataTable dtReserved = DatabaseHelper.ExecuteQuery(reservedQuery);

            List<int> reservedSeatIDs = new List<int>();
            if (dtReserved != null)
            {
                foreach (DataRow row in dtReserved.Rows)
                {
                  
                    reservedSeatIDs.Add(Convert.ToInt32(row["SeatID"]));
                }
            }

          
            string allSeatsQuery = $@"SELECT s.SeatID, s.SeatNumber 
                    FROM dbo.Seats s 
                    INNER JOIN dbo.Sessions sess ON s.HallID = sess.HallID 
                    WHERE sess.SessionID = {_sessionID}
                    ORDER BY s.SeatID ASC";

            DataTable dtAllSeats = DatabaseHelper.ExecuteQuery(allSeatsQuery);

            if (dtAllSeats == null) return;

            
            int seatsPerRow = 10;
            char rowLetter = 'A';

            for (int i = 0; i < dtAllSeats.Rows.Count; i++)
            {
               
                rowLetter = (char)('A' + (i / seatsPerRow));
                int seatNumberInRow = (i % seatsPerRow) + 1;
                string seatDisplayName = $"{rowLetter}{seatNumberInRow}";

                int sID = Convert.ToInt32(dtAllSeats.Rows[i]["SeatID"]);

                
                bool isTaken = reservedSeatIDs.Contains(sID);

                Seat seat = new Seat(seatDisplayName, isTaken);
                seat.Tag = sID;
                seat.StatusChanged += (s, ev) => UpdateCalculation();

                flpSeats.Controls.Add(seat);
            }
        }

        private void UpdateCalculation()
        {
            selectedSeatIDs.Clear();
            lbSelectedSeats.Items.Clear();

            foreach (Control item in flpSeats.Controls)
            {
                if (item is Seat seat && seat.IsSelected)
                {
                    selectedSeatIDs.Add((int)seat.Tag);
                    lbSelectedSeats.Items.Add("Koltuk No: " + seat.SeatNumber);
                }
            }

           
            decimal totalTicket = selectedSeatIDs.Count * prices["Ticket"];

            
            decimal totalBuffet = (numPopcornSmall.Value * prices["PopcornS"]) +
                                  (numPopcornBig.Value * prices["PopcornB"]) +
                                  (numCoke.Value * prices["Coke"]) +
                                  (numWater.Value * prices["Water"]);

           
            decimal grandTotal = totalTicket + totalBuffet;

            
            lblTotalPrice.Text = grandTotal.ToString("0.00") + " TL";
        }

        private void Buffet_ValueChanged(object sender, EventArgs e)
        {
            UpdateCalculation();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (selectedSeatIDs.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir koltuk seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            using (ReservationConfirm confirmForm = new ReservationConfirm())
            {
            
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    
                    string customerName = confirmForm.CustomerName;
                    string customerEmail = confirmForm.CustomerEmail;
                    string customerPhone = confirmForm.CustomerPhone;

                    try
                    {
                   
                        string baseCode = "RES-" + DateTime.Now.Ticks.ToString().Substring(10);

                        foreach (int sID in selectedSeatIDs)
                        {
                            string uniqueResCode = baseCode + "-" + sID;

                         
                            string insertQuery = $@"INSERT INTO dbo.Reservations 
                        (SessionID, SeatID, CustomerName, CustomerEmail, CustomerPhone, ReservationDate, Status, ReservationCode) 
                        VALUES 
                        ({_sessionID}, {sID}, '{customerName}', '{customerEmail}', '{customerPhone}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', 'Confirmed', '{uniqueResCode}')";

                            DatabaseHelper.ExecuteNonQuery(insertQuery);
                        }

                        MessageBox.Show($"Sayın {customerName}, biletleriniz başarıyla alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
                        LoadSeats();
                        lbSelectedSeats.Items.Clear();
                        selectedSeatIDs.Clear();
                        UpdateCalculation();
                        numCoke.value = 0;
                        numPopcornSmall.value = 0;
                        numPopcornBig.value = 0;
                        numWater.value = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message);
                    }
                }
                else
                {
                  
                    MessageBox.Show("İşlem kullanıcı tarafından iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SeatSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            
            
        }
    }
}