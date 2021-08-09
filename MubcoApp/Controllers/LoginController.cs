using Microsoft.AspNetCore.Mvc;
using MubcoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MubcoApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            User model = new User();
            return View(model);
        }
        [HttpPost]
        public IActionResult SignIn(User user)
        {
            var u = UserInit.Init().FirstOrDefault(x => x.UserName == user.UserName && x.Password ==user.Password);
            if (u != null)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.LoginError = "Hatalı  kullanıcı adı veya şifre";
                User model = new User();
                return View(model);
            }
            
        }
        public IActionResult SignOut()
        {
            return RedirectToAction("SignIn");
        }
    }
}
