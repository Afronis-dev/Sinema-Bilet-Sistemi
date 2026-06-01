namespace SinemaBiletOtomasyonu.Classes
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string ImagePath { get; set; } // Afişin bilgisayardaki yolu
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}