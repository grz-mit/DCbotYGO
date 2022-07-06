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
                {"Flip Effect Monster", new EffectMonsterCard()},
                {"Union Effect Monster", new EffectMonsterCard()},
                {"Union Monster", new EffectMonsterCard()},
                {"Spirit Effect Monster", new EffectMonsterCard()},
                {"Spirit Monster", new EffectMonsterCard()},
                {"Gemini Effect Monster", new EffectMonsterCard()},
                {"Gemini Monster", new EffectMonsterCard()},
                {"Tuner Effect Monster", new EffectMonsterCard()},
                {"Tuner Monster", new EffectMonsterCard()},
                {"XYZ Monster", new XYZMonsterCard()},
                {"Link Monster", new LinkMonsterCard()},
                {"Fusion Monster", new FusionMonsterCard()},
                {"Synchro Monster", new SynchroMonsterCard()},
                {"Spell Card", new SpellCard()},
                {"Trap Card", new TrapCard()},
                {"Token", new TokenCard()}
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
