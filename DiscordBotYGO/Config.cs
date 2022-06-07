using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    public class Config
    {
        private ConfigModel configModel;

        public void AddToken()
        {
            configModel = GetConfig();

            Console.WriteLine("Pass Token:");

            using (StreamWriter w = new StreamWriter(Helper.Paths.ConfigFile))
            {
                var serializer = new JsonSerializer();

                configModel.Token = Console.ReadLine();
                serializer.Serialize(w, configModel);
            }
            Console.Clear();

        }
        public void AddConnectionString()
        {
            configModel = GetConfig();

            Console.WriteLine("Pass connection string to DB:");

            using (StreamWriter w = new StreamWriter(Helper.Paths.ConfigFile))
            {
                var serializer = new JsonSerializer();

                configModel.ConnectionString = Console.ReadLine();
                serializer.Serialize(w, configModel);
            }
            Console.Clear();
        }

        public void AddGuildId()
        {
            configModel = GetConfig();

            Console.WriteLine("Pass GuildId:");

            using (StreamWriter w = new StreamWriter(Helper.Paths.ConfigFile))
            {
                var serializer = new JsonSerializer();

                ulong.TryParse(Console.ReadLine(), out ulong guildId);

                configModel.GuildId = guildId;
                serializer.Serialize(w, configModel);
            }
            Console.Clear();
        }

        public ConfigModel GetConfig()
        {
            if (configModel == null)
            {
                using (StreamReader r = new StreamReader(Helper.Paths.ConfigFile))
                {
                    string configJson = r.ReadToEnd();

                    configModel = JsonConvert.DeserializeObject<ConfigModel>(configJson);
                    return configModel;
                }
            }
            else
            {
                return configModel;
            }
        }
    }
}
