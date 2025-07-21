using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReporterDay.BusinessLayer.Abstract;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.PresentationLayer.Controllers
{
    public class AuthorController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticalService _articleService;
        private readonly ICategoryService _categoryService;

        public AuthorController(UserManager<AppUser> userManager, IArticalService articleService, ICategoryService categoryService)
        {
            _userManager = userManager;
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> CreateArtical()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.id = user.Id;
            ViewBag.Name=user.Name + " " + user.Surname;
            List<SelectListItem>values=(from x in _categoryService.TGetAll()
            select new SelectListItem
            {
             Text=x.CategoryName,
             Value=x.CategoryId.ToString()
            }).ToList();  
            ViewBag.categories=values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>CreateArtical(Artical artical)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            artical.AppUserId = user.Id;
            artical.CreatedDate= DateTime.Now;
            _articleService.TInsert(artical);
            return RedirectToAction("Index", "Default");
        }
        public async Task<IActionResult> MyArticalList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _articleService.TGetArticalsByAuthor(user.Id);
            return View(values);        
        }

    }
}
