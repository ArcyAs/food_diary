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

            [Required]
            [Display(Name = "Gender")]
            public string Gender { get; set; }

            [Required]
            [Display(Name = "Activities")]
            public double Activities { get; set; }

            [Display(Name = "ShowBMI")]
            public string ShowBMI = "";

            [Display(Name = "ShowBMR")]
            public string ShowBMR { get; set; }

        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var resultBMI = Input.Weight / ((Input.Height / 100) * (Input.Height / 100));
                if (Input.Gender == "Woman")
                {

                    var resultBMR = (655 + (9.6 * Input.Weight) + (1.8 * Input.Height) - (4.7 * Input.Age)) * Input.Activities;
                    var showBMI = "BMI=" + resultBMI.ToString("0.00");
                    var showBMR = "BMR=" + resultBMR.ToString("0.0" + " kcal");
                    Input.ShowBMI = showBMI;
                    Input.ShowBMR = showBMR;

                }
                else if (Input.Gender == "Man")
                {
                    var resultBMR = (5 + (9.99 * Input.Weight) + (6.25 * Input.Height) - (4.92 * Input.Age)) * Input.Activities;
                    var showBMI = "BMI=" + resultBMI.ToString("0.00");
                    var showBMR = "BMR=" + resultBMR.ToString("0.0" + " kcal");
                    Input.ShowBMI = showBMI;
                    Input.ShowBMR = showBMR;

                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }


    }
}
