namespace ChickenAPI.Models
{
    public class Chicken
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public required string Type { get; set; }
        public required string Location { get; set; }
        public required string EggColor { get; set; }
        public DateTime DateHatched { get; set; }
    }
}