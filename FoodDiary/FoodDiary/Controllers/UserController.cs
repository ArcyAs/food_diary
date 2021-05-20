using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace FoodDiary.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : Controller
    {

        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;

        public UserController(IConfiguration configuration, IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }
        [HttpGet]
        [Route("getUserDetails")]
        public ActionResult<IEnumerable<UserDetailsEntity>> GetUserDetails()
        {
            var result = _userRepository.GetAll();

            return Ok(result);
        }

        [Route("getPersonalDetails")]
        public ActionResult GetAllPersonalDetails()
        {
            var result = _userRepository.GetAllPersonals();
            return Ok(result);

        }




    }
}
