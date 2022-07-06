using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Model
{
    public class CardModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Atk { get; set; }
        public string Def { get; set; }
        public string Level { get; set; }
        public string LinkVal { get; set; }
        public string Race { get; set; }
        public string Attribute { get; set; }
        public string Archetype { get; set; }
        public List<string> LinkMarkers { get; set; }


        [JsonProperty("card_images")]
        public List<CardImageModel> CardImages { get; set; }


    }
}
