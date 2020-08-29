using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LinkaBlog.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult TermsConditions()
        {
            if (User.IsInRole("Banned"))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            if (User.IsInRole("Banned"))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
        public IActionResult Contact()
        {
            if (User.IsInRole("Banned"))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}