using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard
{
    public class NormalMonsterCard : BaseCard
    {
        public string Atk { get; set; }
        public string Def { get; set; }
        public string Level { get; set; }
        public string Attribute { get; set; }
        public string Archetype { get; set; }
        public override DiscordEmbed GetCardEmbed(DiscordEmbedBuilder embed)
        {
            embed.AddField("Name", $"{Name}", false);
            embed.AddField("Level", $"{Level}", false);
            embed.AddField("Race", $"{Race}", false);
            embed.AddField("Attribute", $"{Attribute}", false);
            embed.AddField("Type", $"{Type}", false);
            embed.AddField("Description", $"{Desc}", false);
            embed.AddField("Atk", $"{Atk}", true);
            embed.AddField("Def", $"{Def}", true);
            embed.WithThumbnail($"attachment://{Thumbnail}.jpg");
            embed.WithColor(new DiscordColor("#a2831b")); 

            return embed.Build();
        }
    }
}
