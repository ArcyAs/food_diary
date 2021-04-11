using AutoMapper;
using FoodDiary.Handlers;
using FoodDiary.Models;
using Microsoft.AspNetCore.Identity;

namespace FoodDiary.MapperProfiles
{
    public class IdentityUsersMapperProfile : Profile
    {
        public IdentityUsersMapperProfile()
        {
            CreateMap<AppUser, IdentityUserDto>()
                .ForMember(destination => destination.Email, sourceMember => sourceMember.MapFrom(user => user.Email))
                .ForMember(destination => destination.Guid, sourceMember => sourceMember.MapFrom(user => user.Id));

            CreateMap<IdentityUserDto, AppUser>();
        }
    }
}