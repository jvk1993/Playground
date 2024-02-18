namespace PlaygroundApp.Data.Models.MemoryModels
{
    public class Card
    {
        public string Name { get; set; } = null!;
        public Guid PairId { get; set; }
        public string Picture { get; set; } = null!;
    }
}
