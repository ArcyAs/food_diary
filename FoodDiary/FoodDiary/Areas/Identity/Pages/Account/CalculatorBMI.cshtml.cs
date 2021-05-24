using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AutoMapper;
using FoodDiary.Factories;
using FoodDiary.Models;
using FoodDiary.Models.Enums;
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
        private readonly IBmiBmrFactory _bmibmrFactory;


        public CalculatorBMI(

            ILogger<CalculatorBMI> logger,
            IMapper mapper,
            IBmiBmrFactory bmibmrFactory
            )
        {

            _logger = logger;
            _mapper = mapper;
            _bmibmrFactory = bmibmrFactory;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }
        public string showBMI { get; set; }

        public string showBMR { get; set; }
        public string showInformation { get; set; }
        public string information { get; set; }

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
            public int Gender { get; set; }

            [Required]
            [Display(Name = "Activities")]
            public double Activities { get; set; }


        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {

              showBMI = _bmibmrFactory.GetCalculator((Gender)Enum.ToObject(typeof(Gender), Input.Gender)).CalculateBMI(Input.Weight, Input.Height).ToString("0.00");
              showBMR = _bmibmrFactory.GetCalculator((Gender)Enum.ToObject(typeof(Gender), Input.Gender)).CalculateBMR(Input.Weight, Input.Height, Input.Age, Input.Activities).ToString("0.0" + " kcal");

                var showBMI_value = double.Parse(showBMI);

       
                    if (showBMI_value>25)
                    {
                        information = " Overweight , normal BMI in range 18-25";
                        showInformation = information;
                    }
                else if (showBMI_value<18)
                {
                    information = "Underweight ,normal BMI in range 18-25";
                    showInformation = information;
                }
                else
                {
                    information = "Normal BMI";
                    showInformation = information;
                }
       

       
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }


    }
}
