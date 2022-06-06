using DiscordBotYGO.Data;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands
{
    public class AutocompleteCardName : IAutocompleteProvider
    {
        public Task<IEnumerable<DiscordAutoCompleteChoice>> Provider(AutocompleteContext ctx)
        {
            var context = (DataContext)ctx.Services.GetService(typeof(DataContext));

            return Task.FromResult(context.Cards.Where(n => n.Name.Contains((string)ctx.FocusedOption.Value)).Take(5).Select(c => new DiscordAutoCompleteChoice(c.Name, c.Name)).AsEnumerable());
        }
    }
}
