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
        public override DiscordEmbed GetCardEmbed(DiscordEmbedBuilder embed)
        {
            embed.AddField("Name", $"{Name}", false);
            embed.AddField("Race", $"{Race}", false);
            embed.AddField("Type", $"{Type}", false);
            embed.AddField("Description", $"{Desc}", false);
            embed.WithThumbnail($"attachment://{Thumbnail}.jpg");
            embed.WithColor(new DiscordColor("#930c6e"));

            return embed.Build();
        }
    }
}
