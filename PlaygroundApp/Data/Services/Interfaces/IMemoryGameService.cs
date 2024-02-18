using PlaygroundApp.Data.Enums;
using PlaygroundApp.Data.Models.MemoryModels;

namespace PlaygroundApp.Data.Services.Interfaces
{
    public interface IMemoryGameService
    {
        Task<Memory> StartGame(int amountOfCards, MemoryThemes? memoryTheme);
    }
}
