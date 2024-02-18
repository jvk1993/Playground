namespace PlaygroundApp.Data.Models.MemoryModels
{
    public sealed class Memory : Game
    {
        public List<Card> GameCards { get; set; } = [];
        public Guid LastCheckedPairId { get; set; } = Guid.Empty;

        public Memory()
        {
            Turn = 1;
            AmountOfTurns = 1;
        }
    }
}
