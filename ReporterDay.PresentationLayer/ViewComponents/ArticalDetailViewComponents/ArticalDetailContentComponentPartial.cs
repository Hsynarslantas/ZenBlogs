using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;

namespace ReporterDay.PresentationLayer.ViewComponents.ArticalDetailViewComponents
{
    public class ArticalDetailContentComponentPartial:ViewComponent
    {
        private readonly IArticalService _articalService;

        public ArticalDetailContentComponentPartial(IArticalService articalService)
        {
            _articalService = articalService;
        }

        public IViewComponentResult Invoke(int id)
        { 
            var values=_articalService.TGetArticalsWithAuthorAndCategoriesById(id);
            return View(values);
        }
    }
}
