using AutoMapper;
using DiscordBotYGO.Commands.GetCard;
using DiscordBotYGO.Data;
using DiscordBotYGO.Model;
using DiscordBotYGO.Services;
using DSharpPlus;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands
{
    [ModuleLifespan(ModuleLifespan.Transient)]
    public class GetCardCommand : ApplicationCommandModule
    {
        private readonly CardRequest _cardRequest;
        private readonly CardMessage _cardMessage;
        private readonly ICardRepository _cardRepository;
        private readonly CardResolver _cardResolver;
        private readonly DiscordEmbedBuilder _discordEmbedBuilder;


        public GetCardCommand(CardRequest cardRequest, ICardRepository cardRepository, CardResolver cardResolver,
                                         DiscordEmbedBuilder discordEmbedBuilder, CardMessage cardMessage)
        {
            _cardRequest = cardRequest;
            _cardRepository = cardRepository;
            _cardResolver = cardResolver;
            _discordEmbedBuilder = discordEmbedBuilder;
            _cardMessage = cardMessage;           
        }

        [SlashCommand("Card", "You can search for card by name")]
        public async Task GetCard(InteractionContext ctx, [Autocomplete(typeof(AutocompleteCardName))]
                                                          [Option("Name","Name of card",true)] string name)
        {       
            var cardFromDb = await _cardRepository.GetCardByName(name);

            if (cardFromDb == null)
            {
                var cardFromRequest = await _cardRequest.GetCard(name);

                if (cardFromRequest == null)
                {
                    await ctx.CreateResponseAsync(Helper.Messages.CardNotFound(name));
                }
                else
                {
                    await _cardRepository.AddCard(cardFromRequest);
                    
                    CardImage.Download(cardFromRequest);                
                    var concreteCardEmbed = _cardResolver.MapToConcreteCardType(cardFromRequest).GetCardEmbed(_discordEmbedBuilder).Build();
                    _cardMessage.CreateCardMessage(ctx, concreteCardEmbed, cardFromRequest.Id);
                }
            }
            else
            {
                CardImage.Download(cardFromDb);             
                var concreteCardEmbed = _cardResolver.MapToConcreteCardType(cardFromDb).GetCardEmbed(_discordEmbedBuilder).Build();        
                _cardMessage.CreateCardMessage(ctx, concreteCardEmbed, cardFromDb.Id);             
            }

        }
    }
}
