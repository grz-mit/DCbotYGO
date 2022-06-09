using AutoMapper;
using DiscordBotYGO.Commands.GetCard.CardTypes;
using DiscordBotYGO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Commands.GetCard
{
    public class CardResolver
    {
        private readonly IMapper _mapper;

        public CardResolver(IMapper mapper)
        {
            _mapper = mapper;
        }

        private Dictionary<string, BaseCard> GetCardTypesDict()
        {
            return new Dictionary<string, BaseCard>
            {
                {"Normal Monster", new NormalMonsterCard()},
                {"Effect Monster", new EffectMonsterCard()},
                {"XYZ Monster", new XYZMonsterCard()},
                {"Spell Card", new SpellCard()},
                {"Trap Card", new TrapCard()}
            };
        }

        public BaseCard MapToConcreteCardType(CardModel cardModel)
        {
            var cardTypesDict = GetCardTypesDict();
            var concreteCardModel = cardTypesDict[cardModel.Type];
            var mappedCard = _mapper.Map(cardModel, concreteCardModel);

            return mappedCard;
        }
        

    }
}
