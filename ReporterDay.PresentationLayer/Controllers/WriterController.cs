using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.PresentationLayer.Controllers
{
    public class WriterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticalService _articalService;
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;

        public WriterController(IArticalService articleService, UserManager<AppUser> userManager, ICategoryService categoryService, ICommentService commentService)
        {
            _articalService = articleService;
            _userManager = userManager;
            _categoryService = categoryService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
                return RedirectToAction("Login", "Account");

            var allArticles = _articalService.TGetAll(); // Tüm kullanıcıların makaleleri
            int totalArticles = allArticles.Count;

            var recentArticles = allArticles
                .OrderByDescending(a => a.CreatedDate)
                .Take(5)
                .ToList();

            ViewBag.TotalArticles = totalArticles;
            ViewBag.RecentArticles = recentArticles;

            return View();
        }


        public IActionResult MyArtical()
        {
            // Tüm makaleleri getir (sadece yazarın değil)
            var values = _articalService.TGetAll();
            return View(values); // Model olarak tüm makaleleri gönder
        }
    }
}
