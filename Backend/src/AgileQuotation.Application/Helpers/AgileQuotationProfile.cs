using System;
using AutoMapper;
using AgileQuotation.Application.Dtos;
using AgileQuotation.Domain;
using AgileQuotation.Domain.Identity;
using AgileQuotation.Persistence.Models;

namespace AgileQuotation.API.Helpers
{
    public class AgileQuotationProfile : Profile
    {
        public AgileQuotationProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}