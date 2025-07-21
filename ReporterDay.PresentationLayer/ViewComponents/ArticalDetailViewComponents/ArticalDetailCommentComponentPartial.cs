using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;

namespace ReporterDay.PresentationLayer.ViewComponents.ArticalDetailViewComponents
{
    public class ArticalDetailCommentComponentPartial:ViewComponent
    {
       private readonly ICommentService _commentService;

        public ArticalDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values=_commentService.TGetCommentsByArticalsId(id);
            return View(values);
        }

    }
}
