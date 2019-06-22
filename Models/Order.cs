namespace GameStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}