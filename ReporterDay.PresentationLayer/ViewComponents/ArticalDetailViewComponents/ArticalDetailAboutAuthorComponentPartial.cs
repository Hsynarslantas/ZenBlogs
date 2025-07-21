using Microsoft.AspNetCore.Mvc;

namespace ReporterDay.PresentationLayer.ViewComponents.ArticalDetailViewComponents
{
    public class ArticalDetailAboutAuthorComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
