using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.DataAccessLayer.Abstract
{
    public interface IArticalDal:IGenericDal<Artical>
    {
        List<Artical> GetArticalsByCategoryId1();
        List<Artical> GetArticalsWithAppUser();
        List<Artical> GetArticalsWithCategories();
        List<Artical> GetArticalsWithCategoriesAndAppUsers();
        Artical GetArticalsWithAuthorAndCategoriesById(int id);
        List<Artical> GetArticalsByAuthor(string id);
        IQueryable<Artical> GetQueryableWithCategories();
        Artical GetBySlug(string slug);
    }

}
