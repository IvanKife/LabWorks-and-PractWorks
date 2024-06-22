namespace PractWork6
{
    public class Game
    {
        public int IdGame { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string PriceConverter { get => $"{Price:0.00} руб"; }
    }
}
