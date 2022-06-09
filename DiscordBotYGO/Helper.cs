using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    public static class Helper
    {
        public static class Api
        {
            public static HttpClient ApiClient { get; set; }

            public static void InitializeClient()
            {
                ApiClient = new HttpClient();
                ApiClient.BaseAddress = new Uri("https://db.ygoprodeck.com/api/v7/");
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

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
