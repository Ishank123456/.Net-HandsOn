using AutoMapper;
using Practice_APIWithView_MVC_Login.DTOs;
using Practice_APIWithView_MVC_Login.Models;

namespace Practice_APIWithView_MVC_Login.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserProfileDTO, UserProfile>();
        }
    }
}
