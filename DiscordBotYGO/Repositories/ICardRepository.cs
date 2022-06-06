using DiscordBotYGO.Model;
using System.Threading.Tasks;

namespace DiscordBotYGO.Services
{
    public interface ICardRepository
    {
        Task AddCard(CardModel cardModel);
        Task<CardModel> GetCardByName(string name);
    }
}