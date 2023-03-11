using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EduHome.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
