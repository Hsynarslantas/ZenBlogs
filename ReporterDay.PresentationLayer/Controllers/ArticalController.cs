using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.PresentationLayer.Controllers
{
    public class ArticalController : Controller
    {
        private readonly IArticalService _articalService;

        public ArticalController(IArticalService articalService)
        {
            _articalService = articalService;
        }

        public IActionResult ArticalDetail(string slug)
        {
            var artical = _articalService.TGetBySlug(slug);
            if (artical == null)
            {
                return NotFound();
            }

            ViewBag.v1 = artical.ArticalId;         
            ViewBag.ArticleSlug = artical.Slug;     
            return View(artical);
        }

    }
}



