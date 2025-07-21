using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;

namespace ReporterDay.PresentationLayer.ViewComponents.ArticalDetailViewComponents
{
    public class ArticalDetailTagListComponentPartial:ViewComponent
    {
        private readonly ITagService _tagservice;

        public ArticalDetailTagListComponentPartial(ITagService tagservice)
        {
            _tagservice = tagservice;
        }

        public IViewComponentResult Invoke()
        {
            var values = _tagservice.TGetAll();
            return View(values);
        }
    }
}
