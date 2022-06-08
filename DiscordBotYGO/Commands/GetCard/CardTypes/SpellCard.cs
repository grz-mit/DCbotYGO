using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard
{
    public class SpellCard : BaseCard
    {
        public override DiscordEmbedBuilder GetCardEmbed(DiscordEmbedBuilder embed)
        {
            embed = base.GetCardEmbed(embed);
            embed.WithColor(new DiscordColor("#43c48e"));

            return embed;
        }
    }
}
