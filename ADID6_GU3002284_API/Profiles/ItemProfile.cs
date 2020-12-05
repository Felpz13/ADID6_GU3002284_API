using ADID6_GU3002284_API.Entidades;
using ADID6_GU3002284_API.Entidades.Helpers;
using ADID6_GU3002284_API.Models.itensController;
using AutoMapper;
using System;

namespace ADID6_GU3002284_API.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<IncluirItemModel, Item>()
                .ForMember(dest => dest.Imagem, opt => opt
                    .MapFrom(src => src.Imagem != null ? ImagemHelper.IformFileToByteArray(src.Imagem) : null));

            CreateMap<AtualizarItemModel, Item>()
                .ForMember(dest => dest.Imagem, opt => opt
                    .MapFrom(src => src.Imagem != null ? ImagemHelper.IformFileToByteArray(src.Imagem) : null));

            CreateMap<Item, ObterItemModel>()
                .ForMember(dest => dest.Imagem, opt => opt
                    .MapFrom(src => src.Imagem != null ? $"data:image/png;base64,{Convert.ToBase64String(src.Imagem)}" : null)); 
        }
    }
}
