using System.Collections.Generic;
using FoodDiary.Handlers;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace FoodDiary.Requests
{
    public class GetAllUsersFromContextRequest: IRequest<IEnumerable<IdentityUserDto>>
    {
        
    }
}