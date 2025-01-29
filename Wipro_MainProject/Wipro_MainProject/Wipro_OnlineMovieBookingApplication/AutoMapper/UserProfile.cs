using Wipro_OnlineMovieBookingApplication.ViewModels;
using AutoMapper;

namespace Wipro_OnlineMovieBookingApplication.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, EditUserViewModel>().
                ForSourceMember(dest => dest.Name, opt => opt.DoNotValidate());
        }
    }
}
