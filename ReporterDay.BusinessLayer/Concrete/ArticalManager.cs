using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReporterDay.BusinessLayer.Abstract;
using ReporterDay.DataAccessLayer.Abstract;
using ReporterDay.DataAccessLayer.EntityFramework;
using ReporterDay.EntityLayer.Entities;
using X.PagedList;
using X.PagedList.Extensions;

namespace ReporterDay.BusinessLayer.Concrete
{
    public class ArticalManager : IArticalService
    {
        private readonly IArticalDal _articalDal;

        public ArticalManager(IArticalDal articalDal)
        {
            _articalDal = articalDal;
        }


        public void TDelete(int id)
        {
            _articalDal.Delete(id);
        }

        public List<Artical> TGetAll()
        {
            return _articalDal.GetAll();
        }

        public List<Artical> TGetArticalsByAuthor(string id)
        {
            return _articalDal.GetArticalsByAuthor(id);
        }

        public List<Artical> TGetArticalsByCategoryId1()
        {
            return _articalDal.GetArticalsByCategoryId1();
        }

        public List<Artical> TGetArticalsWithAppUser()
        {
            return _articalDal.GetArticalsWithAppUser();
        }

        public Artical TGetArticalsWithAuthorAndCategoriesById(int id)
        {
            return _articalDal.GetArticalsWithAuthorAndCategoriesById(id);
        }

        public List<Artical> TGetArticalsWithCategories()
        {
           return _articalDal.GetArticalsWithCategories();
        }

        public List<Artical> TGetArticalsWithCategoriesAndAppUsers()
        {
            return _articalDal.GetArticalsWithCategoriesAndAppUsers();
        }

        public Artical TGetById(int id)
        {
            return _articalDal.GetById(id);
        }

        public IEnumerable<object> TGetList()
        {
            throw new NotImplementedException();
        }

        

         public IPagedList<Artical> GetPagedArticals(int page, int pageSize)
          {
            return _articalDal.GetQueryableWithCategories()
            .ToPagedList(page, pageSize);
         }


    public void TInsert(Artical entity)
        {
            if (entity.Title != null && entity.Title.Length >= 10 && entity.CategoryId != 0 && entity.Content.Length <= 1000)
            {
                _articalDal.Insert(entity);
            }
            else
            {
                // Hata Mesajı
            }

        }

        public void TUpdate(Artical entity)
        {
            _articalDal.Update(entity);
        }

        public IQueryable<Artical> TGetQueryableWithCategories()
        {
            throw new NotImplementedException();
        }

      

        Artical IArticalService.TGetBySlug(string slug)
        {
            return _articalDal.GetBySlug(slug);
        }
    }
}
