using AutoMapper;
using Wipro_OnlineMovieBookingApplication_MainProject.ViewModels;

namespace Wipro_OnlineMovieBookingApplication_MainProject.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserViewModel, EditUserViewModel>().
                ForSourceMember(dest => dest.Name, opt => opt.DoNotValidate());
        }
    }
}
