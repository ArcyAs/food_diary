using System.Collections.Generic;
using System.Threading.Tasks;
using FoodDiary.Handlers;
using FoodDiary.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodDiary.Controllers
{
    // api dostępne z poziomu Postmana. w url wpisujemy https://localhost:5001/api/example
    [Route("api/example")]
    public class MediatRExampleController : Controller
    {
        private readonly IMediator _mediator;

        public MediatRExampleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<IdentityUserDto>> GetAllUsersFromContext(GetAllUsersFromContextRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}