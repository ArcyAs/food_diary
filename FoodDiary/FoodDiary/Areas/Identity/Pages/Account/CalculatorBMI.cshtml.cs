using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using FoodDiary.Factories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FoodDiary.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class CalculatorBMI : PageModel
    {
        private readonly IBmiBmrFactory _bmibmrFactory;

        private readonly ILogger<CalculatorBMI> _logger;
        private readonly IMapper _mapper;


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

        [BindProperty] public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }
        public string showBMI { get; set; }

        public string showBMR { get; set; }
        public string showInformation { get; set; }
        public string information { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required] [Display(Name = "Age")] public int Age { get; set; }

            [Required] [Display(Name = "Height")] public double Height { get; set; }

            [Required] [Display(Name = "Weight")] public double Weight { get; set; }

            [Required] [Display(Name = "Gender")] public int Gender { get; set; }

            [Required]
            [Display(Name = "Activities")]
            public double Activities { get; set; }
        }
    }
}