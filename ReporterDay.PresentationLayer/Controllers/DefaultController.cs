using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}