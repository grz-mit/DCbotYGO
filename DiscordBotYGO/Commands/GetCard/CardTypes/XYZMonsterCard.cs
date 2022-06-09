using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard.CardTypes
{
    public class XYZMonsterCard : BaseCard
    {
        public string Atk { get; set; }
        public string Def { get; set; }
        public string Level { get; set; }
        public string Attribute { get; set; }
        public string Archetype { get; set; }

        public override DiscordEmbedBuilder GetCardEmbed(DiscordEmbedBuilder embed)
        {
            embed = base.GetCardEmbed(embed);
            embed.AddField("Level", $"{Level}", false);
            embed.AddField("Attribute", $"{Attribute}", false);
            embed.AddField("Atk", $"{Atk}", true);
            embed.AddField("Def", $"{Def}", true);
            embed.WithColor(new DiscordColor("#010101"));

            return embed;
        }
    }
}
