using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodDiary.Models;
using FoodDiary.Requests;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace FoodDiary.Handlers
{
    public class
        GetAllUsersFromContextHandler : IRequestHandler<GetAllUsersFromContextRequest, IEnumerable<IdentityUserDto>>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public GetAllUsersFromContextHandler(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public Task<IEnumerable<IdentityUserDto>> Handle(GetAllUsersFromContextRequest request,
            CancellationToken cancellationToken)
        {
            //domyślnie encja zawiera bardzo dużo informacji o użytkownikach. Zamiast tworzyć ręczne mapowanie, możemy wykorzystać mappera i profile mapowania.
            //to mapowanie jeste zdefiniowane IdentityUsersMapperProfile. W wyniku mapowania ograniczymy ilość prezentowanych użytkownikowi informacji.
            var users = new List<AppUser>();
            foreach (var user in _userManager.Users) users.Add(user);
            var mappedUsers = _mapper.Map<IEnumerable<IdentityUserDto>>(users);
            return Task.FromResult(mappedUsers);
        }
    }
}