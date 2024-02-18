using PlaygroundApp.Data.Enums;
using PlaygroundApp.Data.Models.MemoryModels;
using PlaygroundApp.Data.Services.Interfaces;
using System;

namespace PlaygroundApp.Data.Services
{
    public class MemoryGameService : IMemoryGameService
    {
        private readonly string[] _defaultNames = ["Draven", "Xayah", "BlitzCrank"];
        private readonly Random _random = new();

        public async Task<Memory> StartGame(int amountOfCards, MemoryThemes? memoryTheme)
        {
            if(memoryTheme is null) // CHECK IF A ENUM CAN BE NULL
            {
            }
            // TODO SET THEME BASED ON INPUT

            await Task.Delay(10);

            Memory memory = new()
            {
                GameCards = CreateCardsForGame(amountOfCards)
            };

            return memory;
        }

        private List<Card> CreateCardsForGame(int amountOfCards)
        {
            List<Card> cards = [];
            for(int i = 0; i < amountOfCards; i+=2)
            {
                Guid pairId = Guid.NewGuid();
                string randomString = RandomString(5);
                for (int j = 0; j < 2; j++)
                {     
                    Card card = new() { PairId = pairId, Name = randomString, Picture = "" };
                    cards.Add(card);
                }
            }
            return cards;
        }

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
