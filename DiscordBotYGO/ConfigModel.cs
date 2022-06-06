using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    public class ConfigModel
    {
        public string Token { get; set; }
        public string ConnectionString { get; set; }
        public ulong GuildId { get; set; }
    }
}
