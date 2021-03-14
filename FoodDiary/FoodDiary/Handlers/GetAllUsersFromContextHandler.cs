using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodDiary.Requests;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace FoodDiary.Handlers
{
    public class GetAllUsersFromContextHandler : IRequestHandler<GetAllUsersFromContextRequest, IEnumerable<IdentityUserDto>>
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;

        public GetAllUsersFromContextHandler(UserManager<IdentityUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IdentityUserDto>> Handle(GetAllUsersFromContextRequest request, CancellationToken cancellationToken)
        {
            //domyślnie encja zawiera bardzo dużo informacji o użytkownikach. Zamiast tworzyć ręczne mapowanie, możemy wykorzystać mappera i profile mapowania.
            //to mapowanie jeste zdefiniowane IdentityUsersMapperProfile. W wyniku mapowania ograniczymy ilość prezentowanych użytkownikowi informacji.
            var users = _userManager.Users.ToList();
            var mappedUsers = _mapper.Map<IEnumerable<IdentityUserDto>>(users);
            return mappedUsers;
        }
    }
}