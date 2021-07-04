using System.Collections.Generic;
using FoodDiary.Handlers;
using MediatR;

namespace FoodDiary.Requests
{
    public class GetAllUsersFromContextRequest : IRequest<IEnumerable<IdentityUserDto>>
    {
    }
}