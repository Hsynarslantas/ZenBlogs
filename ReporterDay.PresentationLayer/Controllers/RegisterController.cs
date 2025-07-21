using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReporterDay.EntityLayer.Entities;
using ReporterDay.PresentationLayer.Models;

namespace ReporterDay.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var appUser = new AppUser
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.Username,
                ImageUrl = model.ImageUrl ?? "default.jpg",  // varsayılan resim
                Description = model.Description ?? "Yazar"
            };

            var result = await _userManager.CreateAsync(appUser, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("UserLogin", "Login");
            }

            // Hataları ModelState'e ekleyelim
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }
    }
}
