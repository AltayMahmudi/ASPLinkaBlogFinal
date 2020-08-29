using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkaBlog.Models;
using LinkaBlog.Services.Email;
using LinkaBlog.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LinkaBlog.Controllers
{
    public class AuthController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager/*IEmailService emailService*/)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            //_emailService = emailService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginView)
        {
            if (ModelState.IsValid)
            {
            
                var result = await _signInManager.PasswordSignInAsync(loginView.UserName, loginView.Password, loginView.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }ModelState.AddModelError("", "Invalid login attempt");
            return View(loginView);
        }
        [HttpGet]
        public async Task< IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            if (vm.PrivacyPolicy==false)
            {
                return View(vm);
            }

            if (vm.TermsConditions == false)
            {
                return View(vm);
            }
            var user = new IdentityUser
            {
                UserName = vm.UserName,
                Email = vm.Email

            };
            var result = await _userManager.CreateAsync(user, "password");
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                //await _emailService.SendEmail(user.Email, "Welcome", "Thank you for registering");
                return RedirectToAction("Index", "Home");

            };
            return View(vm);
        }

    }
}