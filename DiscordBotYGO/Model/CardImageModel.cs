using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Model
{
    public class CardImageModel
    {
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("image_url_small")]
        public string ImageUrlSmall { get; set; }
    }
}
