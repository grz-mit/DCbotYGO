using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    public class BotMenu
    {
        private readonly Config _config;
        private bool run = false;

        public BotMenu(Config config)
        {
            _config = config;
        }

        public async Task Options()
        {
            do
            {
                Console.WriteLine("Press specific button to choose option:\n" +
                    "1 - Run bot\n" +
                    "2 - Add Token\n" +
                    "3 - Add Guild ID\n"+
                    "4 - Add Connection String to DB");

                var pressedKey = Console.ReadKey(true);
                
                Console.Clear();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:
                        var bot = new Bot(_config.GetConfig());
                        await bot.Run();
                        run = true;
                        break;

                    case ConsoleKey.D2:
                        _config.AddToken();
                        break;

                    case ConsoleKey.D3:
                        _config.AddGuidId();
                        break;

                    case ConsoleKey.D4:
                        _config.AddConnectionString();
                        break;
                }
            } while (!run);

        }
    }
}
