using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AutoMapper;
using FoodDiary.Data;
using FoodDiary.Models;
using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace FoodDiary.Areas.Identity.Pages.Account
{
    public class YourTarget : PageModel
    {

        private readonly ILogger<YourTarget> _logger;
        private readonly IMapper _mapper;


        public YourTarget(

            ILogger<YourTarget> logger,
            IMapper mapper)
        {

            _logger = logger;
            _mapper = mapper;
        }



        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

  

        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
 
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }


    }
}
