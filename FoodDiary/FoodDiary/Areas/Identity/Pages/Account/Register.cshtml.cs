using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using FoodDiary.Builders;
using FoodDiary.Factories;
using FoodDiary.Models;
using FoodDiary.Models.Enums;
using FoodDiary.Repositories.Abstract;
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
    [AllowAnonymous]
    public class Register : PageModel
    {
        private readonly IBmiBmrFactory _bmibmrFactory;
        private readonly IDiaryRepository _diaryRepository;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<Register> _logger;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserNameBuilder _userNameBuilder;

        public Register(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            ILogger<Register> logger,
            IEmailSender emailSender,
            IUserNameBuilder userNameBuilder,
            IBmiBmrFactory bmiFactory,
            IRepositoryFactory repositoryFactory,
            IDiaryRepository diaryRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _userNameBuilder = userNameBuilder;
            _bmibmrFactory = bmiFactory;
            _repositoryFactory = repositoryFactory;
            _diaryRepository = diaryRepository;
        }

        [BindProperty] public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = Input.Email,

                    NormalizedUserName = _userNameBuilder.Build(Input),
                    Email = Input.Email,
                    Age = Input.Age,
                    ActivityLevel = Input.Activities,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName
                };

                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        null,
                        new {area = "Identity", userId = user.Id, code, returnUrl},
                        Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");


                    var DiaryGuid = Guid.NewGuid();
                    var userDetails = new UserDetailsEntity
                    {
                        Gender = Input.Gender,
                        Height = Input.Height,
                        Weight = Input.Weight,
                        DiaryId = DiaryGuid,
                        Bmr = _bmibmrFactory.GetCalculator((Gender) Enum.ToObject(typeof(Gender), Input.Gender))
                            .CalculateBMR(Input.Weight, Input.Height, Input.Age, Input.Activities),
                        Bmi = _bmibmrFactory.GetCalculator((Gender) Enum.ToObject(typeof(Gender), Input.Gender))
                            .CalculateBMI(Input.Weight, Input.Height),
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse(user.Id),
                        AddDate = DateTime.Now
                    };

                    await _repositoryFactory.GetUserRepository().AddUserDetails(userDetails);

                    var diary = new DiaryEntity
                    {
                        Id = Guid.NewGuid(),
                        DiaryId = DiaryGuid,
                        AddDate = DateTime.Now
                    };
                    await _diaryRepository.AddDiary(diary);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                        return RedirectToPage("RegisterConfirmation", new {email = Input.Email, returnUrl});

                    await _signInManager.SignInAsync(user, false);
                    return LocalRedirect(returnUrl);
                }

                foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        public class InputModel
        {
            [Required] [Display(Name = "Email")] public string Email { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required] [Display(Name = "Gender")] public int Gender { get; set; }

            [Required] [Display(Name = "Height")] public int Height { get; set; }

            [Required] [Display(Name = "Age")] public int Age { get; set; }

            [Required] [Display(Name = "Weight")] public double Weight { get; set; }

            // [Required]
            // [EmailAddress]
            // [Display(Name = "BMI")]
            // public double Bmi { get; set; }
            //
            // [Required]
            // [EmailAddress]
            // [Display(Name = "BMR")]
            // public double Bmr { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "Activities")]
            public double Activities { get; set; }
        }
    }
}