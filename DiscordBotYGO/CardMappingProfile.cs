using AutoMapper;
using DiscordBotYGO.Commands.GetCard;
using DiscordBotYGO.Commands.GetCard.CardTypes;
using DiscordBotYGO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO
{
    public class CardMappingProfile : Profile
    {
        public CardMappingProfile()
        {
            CreateMap<CardModel, NormalMonsterCard>().ForMember(n=>n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, SpellCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, TrapCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, EffectMonsterCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, XYZMonsterCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, LinkMonsterCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, FusionMonsterCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, TokenCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
            CreateMap<CardModel, SynchroMonsterCard>().ForMember(n => n.Thumbnail, map => map.MapFrom(c => c.Id));
        }
    }
}
