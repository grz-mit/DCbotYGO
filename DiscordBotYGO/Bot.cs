using DiscordBotYGO.Commands;
using DiscordBotYGO.Commands.GetCard;
using DiscordBotYGO.Data;
using DiscordBotYGO.Services;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    public class Bot
    {
        private readonly ConfigModel _configModel;   
        
        public Bot(ConfigModel configModel)
        {
            _configModel = configModel;
        }

        public async Task Run()
        {
            Helper.Api.InitializeClient();

            var servicesCollection = new ServiceCollection();

            //registerig services
            servicesCollection.AddDbContext<DataContext>(options =>
                              options.UseSqlServer(_configModel.ConnectionString));

            servicesCollection.AddScoped<ICardRepository, CardRepository>();
            servicesCollection.AddScoped<CardRequest>();
            servicesCollection.AddTransient<CardMessage>();
            servicesCollection.AddTransient<DiscordEmbedBuilder>();
            servicesCollection.AddTransient<DiscordInteractionResponseBuilder>();
            servicesCollection.AddScoped<CardResolver>();
            servicesCollection.AddAutoMapper(this.GetType().Assembly);
            
            var discordClient = new DiscordClient(new DiscordConfiguration()
            {
                Token = _configModel.Token,
                TokenType = TokenType.Bot
            });

            var slashCommands = discordClient.UseSlashCommands(new SlashCommandsConfiguration()
            {
                Services = servicesCollection.BuildServiceProvider()
            });

            slashCommands.RegisterCommands<GetCardCommand>(_configModel.GuildId);

            await discordClient.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
