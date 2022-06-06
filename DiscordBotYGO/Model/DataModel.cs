using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Model
{
    public class DataModel
    {
        [JsonProperty("data")]
        public List<CardModel> CardModel { get; set; }
    }
}
