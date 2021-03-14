using AutoMapper;
using FoodDiary.Handlers;
using Microsoft.AspNetCore.Identity;

namespace FoodDiary.MapperProfiles
{
    public class IdentityUsersMapperProfile : Profile
    {
        public IdentityUsersMapperProfile()
        {
            CreateMap<IdentityUser, IdentityUserDto>()
                .ForMember(destination => destination.Email, sourceMember => sourceMember.MapFrom(user => user.Email))
                .ForMember(destination => destination.Guid, sourceMember => sourceMember.MapFrom(user => user.Id));

            CreateMap<IdentityUserDto, IdentityUser>();
        }
    }
}