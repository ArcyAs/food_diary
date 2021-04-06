using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AutoMapper;
using FoodDiary.Models;
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
    [AllowAnonymous]
    public class CalculatorBMI : PageModel
    {

        private readonly ILogger<CalculatorBMI> _logger;
        private readonly IMapper _mapper;


        public CalculatorBMI(

            ILogger<CalculatorBMI> logger,
            IMapper mapper)
        {

            _logger = logger;
            _mapper = mapper;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Age")]
            public int Age { get; set; }

            [Required]
            [Display(Name = "Height")]
            public double Height { get; set; }

            [Required]
            [Display(Name = "Weight")]
            public double Weight { get; set; }

            [Display(Name = "Result")]
            public double Result { get; set; }
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {

                var result =Input.Weight/((Input.Height/100)*(Input.Height/100));
                if (result>0)
                {
                    ModelState.AddModelError(string.Empty, "BMI="+ result.ToString("0.00"));
                    return Page();
                }
              
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Data.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }


    }
}
