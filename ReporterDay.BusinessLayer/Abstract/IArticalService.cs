using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReporterDay.EntityLayer.Entities;
using X.PagedList;

namespace ReporterDay.BusinessLayer.Abstract
{
    public interface IArticalService:IGenericService<Artical>
    {
        public List<Artical> TGetArticalsByCategoryId1();
        public List<Artical> TGetArticalsWithAppUser();
        public List<Artical> TGetArticalsWithCategories();
        List<Artical> TGetArticalsWithCategoriesAndAppUsers();
        public Artical TGetArticalsWithAuthorAndCategoriesById(int id);
        List<Artical> TGetArticalsByAuthor(string id);
        IEnumerable<object> TGetList();
        IPagedList<Artical> GetPagedArticals(int page, int pageSize);
        Artical TGetBySlug(string slug);
    }
}
