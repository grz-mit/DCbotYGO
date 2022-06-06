using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    public static class Helper
    {
        public static class Messages
        {
            public const string Menu = "Press specific button to choose option:\n" +
                    "1 - Run bot\n" +
                    "2 - Add Token\n" +
                    "3 - Add Guild ID\n" +
                    "4 - Add Connection String to DB";

            public static string CardNotFound(string name)
            {
                return $"Card {name} not found.";
            }
            
        }

        public static class Paths
        {
            public static string ImageDirectory = Environment.CurrentDirectory + "\\CardImages\\";
            public static string ConfigFile = Environment.CurrentDirectory + "\\Config\\config.json";
        }
    }
}
