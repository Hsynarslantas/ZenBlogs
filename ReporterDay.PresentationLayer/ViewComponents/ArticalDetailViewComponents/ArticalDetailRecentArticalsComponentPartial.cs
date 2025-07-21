using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;

namespace ReporterDay.PresentationLayer.ViewComponents.ArticalDetailViewComponents
{
    public class ArticalDetailRecentArticalsComponentPartial:ViewComponent
    {
        private readonly IArticalService _articalService;

        public ArticalDetailRecentArticalsComponentPartial(IArticalService articalService)
        {
            _articalService = articalService;
        }
        public IViewComponentResult Invoke()
        {
            var recentArticals = _articalService.TGetAll()
                .OrderByDescending(x => x.CreatedDate)
                .Take(5)
                .ToList();
            return View(recentArticals);
        }
    }
}
