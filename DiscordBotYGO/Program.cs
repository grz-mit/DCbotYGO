using System;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var botMenu = new BotMenu(new Config());
            await botMenu.Options();
        }
    }
}
