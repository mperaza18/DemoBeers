namespace DemoBeers.Domain.Entities
{
    public class Beer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Pack { get; set; }
        public decimal AbvPercentage { get; set; }
        public int Ibu { get; set; }
        public string? Description { get; set; }
    }
}
