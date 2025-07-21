using Microsoft.AspNetCore.Mvc;

namespace ReporterDay.PresentationLayer.ViewComponents.ArticalDetailViewComponents
{
    public class ArticalDetailNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
