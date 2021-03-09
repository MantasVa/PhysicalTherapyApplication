using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure;
using PhysicalTherapyProject.Application.Models.DTO;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Routing;

namespace PhysicalTherapyProjectV2.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AuthorizationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserRepository _userRepository;
        public AuthorizationController(IMapper mapper, UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
        }
        [HttpGet("registracija")]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost("registracija")]
        public async Task<IActionResult> Registration(RegistrationDto userModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            var user = _mapper.Map<ApplicationUser>(userModel);
            user.EmailConfirmationToken = Guid.NewGuid();

            var result = await _userManager.CreateAsync(user, userModel.Password);

            //if (!result.Succeeded)
            //{
                
            //    foreach (var error in result.Errors)
            //    {
            //        if(!ModelState.ContainsKey("EmailExists") && error.Description.EndsWith("is already taken."))
            //            ModelState.TryAddModelError("EmailExists", "Naudotojas su tokiu el. paštu jau egzistuoja.");
            //        else
            //            ModelState.TryAddModelError(error.Code, error.Description);
            //    }

            //    return View(userModel);

            //}
            await _userManager.AddToRoleAsync(user, "Naudotojas");

            SendAccountConfirmation(user.Email, user.EmailConfirmationToken.ToString());

            return RedirectToAction(nameof(Login));
        }

        [HttpGet("prisijungimas")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost("prisijungimas")]
        public async Task<IActionResult> Login(LoginDto loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            var user = await _userRepository.GetByEmailAsync(loginModel.Email);

            //if (!user.EmailConfirmed)
            //{
            //    if (!user.EmailConfirmationToken.HasValue)
            //    {
            //        user.EmailConfirmationToken = Guid.NewGuid();
            //        await _userManager.UpdateAsync(user);
            //    }

            //    SendAccountConfirmation(user.Email, user.EmailConfirmationToken.ToString());
            //    return RedirectToAction(nameof(ConfirmUserEmail));
            //}

            var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.TryAddModelError("BadLoginInfo", "Neteisingai įvesti prisijungimo duomenys!");

                return View(loginModel);
            }

            return Redirect("straipsniai/puslapis/1");            
        }

        [HttpGet("slaptazodzio-priminimas")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost("slaptazodzio-priminimas")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDto model)
        {
            if (ModelState.IsValid)
            {
                // Find the user by email
                var user = await _userManager.FindByEmailAsync(model.Email);
                // If the user is found AND Email is confirmed
                if (user != null)
                {
                    // Generate the reset password token
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                    // Build the password reset link
                    var passwordResetLink = Url.Action(nameof(ResetPassword), "Authorization",
                            new { email = model.Email, token = token }, Request.Scheme);

                    EmailHandler.Send(user.Email, "LKA Slaptažodžio Pakeitimas", $"Spauskite: {passwordResetLink}");

                }
                // To avoid account enumeration and brute force attacks, don't
                // reveal that the user does not exist or is not confirmed
                return View(nameof(ForgotPasswordConfirmation));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ForgotPasswordConfirmation() => View();

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string email, string token)
        {
            if (email == null || token == null)
            {
                ModelState.AddModelError("", "Netinkami duomenys!");
            }
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto model)
        {
            if (ModelState.IsValid)
            {
                // Find the user by email
                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    // reset the user password
                    var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
                    if (result.Succeeded)
                    {
                        return View(nameof(ResetPasswordConfirmation));
                    }
                    // Display validation errors. For example, password reset token already
                    // used to change the password or password complexity rules not met
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }

                // To avoid account enumeration and brute force attacks, don't
                // reveal that the user does not exist
                return View(nameof(ResetPasswordConfirmation));
            }
            // Display validation errors if model state is not valid
            return View(model);
        }

        [HttpGet("slaptazodzio-pakeitimas")]
        public IActionResult ResetPasswordConfirmation() => View();
        
        [HttpGet("patvirtinti-pasta")]
        public IActionResult ConfirmUserEmail()
        {
            return View();
        }

        [HttpGet("pasto-patvirtinimas")]
        public async Task<IActionResult> ConfirmEmail(string email, string token)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if(user != null)
            {
                Guid tokenGuid;
                if(Guid.TryParse(token, out tokenGuid))
                {
                    if (user.EmailConfirmationToken == tokenGuid)
                    {
                        user.EmailConfirmed = true;
                        await _userManager.UpdateAsync(user);

                        return RedirectToAction(nameof(Login));
                    }
                }                
            }   

            return View();
        }
        private void SendAccountConfirmation(string email, string token)
        {
            var accountCofirmLink = Url.Action(nameof(ConfirmEmail), "Authorization",
                            new { email = email, token = token }, Request.Scheme);

            EmailHandler.Send(email, "LKA paskyros patvirtinimas", $"Spauskite: {accountCofirmLink}");
        }

    }
}