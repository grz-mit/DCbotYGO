using DiscordBotYGO.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard
{
    public static class CardImage
    {
        public static void Download (CardModel cardModel)
        {
            var path = Environment.CurrentDirectory + "\\CardImages\\";

            if (!File.Exists(path + cardModel.Id + ".jpg"))
            {
                using (var webClient = new WebClient())
                {
                    webClient.DownloadFile(new Uri(cardModel.CardImages.FirstOrDefault().ImageUrl), path + cardModel.Id + ".jpg");
                }
            }
        }
    }
}
