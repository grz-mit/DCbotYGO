using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard
{
    public abstract class BaseCard
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Race { get; set; }
        public string Thumbnail { get; set; }

        public virtual DiscordEmbedBuilder GetCardEmbed(DiscordEmbedBuilder embed)
        {
            embed.AddField("Name", $"{Name}", false);
            embed.AddField("Race", $"{Race}", false);
            embed.AddField("Type", $"{Type}", false);
            embed.AddField("Description", $"{Desc}", false);
            embed.WithThumbnail($"attachment://{Thumbnail}.jpg");

            return embed;
        }
    }
}
