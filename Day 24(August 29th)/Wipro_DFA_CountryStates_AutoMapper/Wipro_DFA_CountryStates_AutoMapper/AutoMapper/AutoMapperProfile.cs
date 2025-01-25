using AutoMapper;
using Wipro_DFA_CountryStates_AutoMapper.DTO;
using Wipro_DFA_CountryStates_AutoMapper.Models;

namespace Wipro_DFA_CountryStates_AutoMapper.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCountryDTO, Country>().ForMember(dest => dest.CountryName,
                opt => opt.MapFrom(src => src.Name));
            CreateMap<UpdateCountryDTO, Country>().ForMember(dest => dest.CountryName,
                opt => opt.MapFrom(src => src.Name));
            CreateMap<CreateStateDTO, State>();
            CreateMap<UpdateStateDTO, State>();
            CreateMap<CountryStateLstDTO, Country>();
        }
    }
}
