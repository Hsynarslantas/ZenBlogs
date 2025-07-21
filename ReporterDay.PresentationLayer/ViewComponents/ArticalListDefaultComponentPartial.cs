using Microsoft.AspNetCore.Mvc;
using ReporterDay.BusinessLayer.Abstract;
using System;
using System.Threading.Tasks;

public class ArticalListDefaultComponentPartialViewComponent : ViewComponent
{
    private readonly IArticalService _articalService;

    public ArticalListDefaultComponentPartialViewComponent(IArticalService articalService)
    {
        _articalService = articalService ?? throw new ArgumentNullException(nameof(articalService));
    }

    public  IViewComponentResult Invoke(int page = 1)
    {
        int pageSize = 9; 
        var articals =  _articalService.GetPagedArticals(page, pageSize);
        return View(articals);
    }
}

