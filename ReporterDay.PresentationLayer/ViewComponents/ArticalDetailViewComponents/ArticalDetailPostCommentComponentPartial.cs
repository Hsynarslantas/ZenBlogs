using Microsoft.AspNetCore.Mvc;

namespace ReporterDay.PresentationLayer.ViewComponents.ArticalDetailViewComponents
{
    public class ArticalDetailPostCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
