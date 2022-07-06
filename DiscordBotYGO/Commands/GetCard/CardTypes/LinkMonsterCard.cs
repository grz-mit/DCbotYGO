using DiscordBotYGO.Model;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard.CardTypes
{
    public class LinkMonsterCard : BaseCard
    {
        public string Atk { get; set; }
        public string Def { get; set; }
        public string Level { get; set; }
        public string Attribute { get; set; }
        public string Archetype { get; set; }
        public string LinkVal { get; set; }
        public List<string> LinkMarkers { get; set; }   

        public override DiscordEmbedBuilder GetCardEmbed(DiscordEmbedBuilder embed)
        {
            embed = base.GetCardEmbed(embed);
            embed.AddField("Link Value", $"{LinkVal}", false);
            embed.AddField("Link Markers", $"{string.Join(", ",LinkMarkers)}", false);
            embed.AddField("Attribute", $"{Attribute}", false);
            embed.AddField("Atk", $"{Atk}", true);
            embed.WithColor(new DiscordColor("#0b54e6"));

            return embed;
        }
    }
}
