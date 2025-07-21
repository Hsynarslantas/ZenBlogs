using Microsoft.AspNetCore.Mvc;

namespace ReporterDay.PresentationLayer.ViewComponents
{
    public class _HeadDefaultFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
