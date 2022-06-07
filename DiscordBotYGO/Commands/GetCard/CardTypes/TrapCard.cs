using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard.CardTypes
{
    public class TrapCard : BaseCard
    {
        public override DiscordEmbedBuilder GetCardEmbed(DiscordEmbedBuilder embed)
        {
            embed = base.GetCardEmbed(embed);
            embed.WithColor(new DiscordColor("#930c6e"));

            return embed;
        }
    }
}
