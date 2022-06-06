using DiscordBotYGO.Api;
using DiscordBotYGO.Commands.GetCard;
using DiscordBotYGO.Data;
using DiscordBotYGO.Model;
using DiscordBotYGO.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard
{
    public class CardRequest
    {
        private CardModel cardModel;

        public async Task<CardModel> GetCard(string name)
        {
            var url = $"cardinfo.php?name={Uri.EscapeUriString(name)}";

            using (var response = await ApiHelper.ApiClient.GetAsync(url))
            {
                var content = await response.Content.ReadAsStringAsync();
                var dataModel = JsonConvert.DeserializeObject<DataModel>(content);

                if (dataModel.CardModel != null)
                {
                    cardModel = dataModel.CardModel.FirstOrDefault();
                }
                else
                {
                    return null;
                }

                return cardModel;
            }
        }
    }
}
