using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReporterDay.EntityLayer.Entities;
using ReporterDay.PresentationLayer.Models;

namespace ReporterDay.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.password, true, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Dashboard", "Writer");
            }

            ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("UserLogin", "Login");
        }
    }
}
