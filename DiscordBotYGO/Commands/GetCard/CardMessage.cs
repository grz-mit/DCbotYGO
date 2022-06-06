using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard
{
    public class CardMessage
    {
        private readonly DiscordInteractionResponseBuilder _messageBuilder;

        public CardMessage(DiscordInteractionResponseBuilder messageBuilder)
        {
            _messageBuilder = messageBuilder;
        }

        public async void CreateCardMessage (InteractionContext ctx, DiscordEmbed concreteCardEmbed, string cardId)
        {
            var path = Environment.CurrentDirectory + "\\CardImages\\";
            
            using (var fs = new FileStream(path + cardId + ".jpg", FileMode.Open))
            {
                _messageBuilder.AddFile(fs);
                _messageBuilder.AddEmbed(concreteCardEmbed);

                await ctx.CreateResponseAsync(_messageBuilder);
            }
        }

    }
}
