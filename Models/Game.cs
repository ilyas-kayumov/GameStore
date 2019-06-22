namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Platform { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set; }
    }
}