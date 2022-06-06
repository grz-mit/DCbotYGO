using DiscordBotYGO.Data;
using DiscordBotYGO.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Services
{
    public class CardRepository : ICardRepository
    {
        private readonly DataContext _context;

        public CardRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<CardModel> GetCardByName(string name)
        {
            return await _context.Cards.Include(c => c.CardImages).FirstOrDefaultAsync(c => c.Name == name);
        }

        public async Task AddCard(CardModel cardModel)
        {
            await _context.Cards.AddAsync(cardModel);
            await _context.SaveChangesAsync();
        }
    }
}
