﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using Wipro_OnlineMovieBookingApplication.ViewModels;
using AutoMapper;
using Domain.Models;

namespace Wipro_OnlineMovieBookingApplication.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, EditUserViewModel>().
                ForSourceMember(dest => dest.Name, opt => opt.DoNotValidate());

            CreateMap<MovieViewModel, EditMovieViewModel>()
            .ForMember(dest => dest.MoviePrice, opt => opt.Ignore());

            //CreateMap<Movie, BookingViewModel>()
            //.ForMember(dest => dest.MoviePrice, opt => opt.MapFrom(src => src.MoviePrice));
        }
    }
}
