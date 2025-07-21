using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReporterDay.DataAccessLayer.Abstract;
using ReporterDay.DataAccessLayer.Context;
using ReporterDay.DataAccessLayer.Repositories;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.DataAccessLayer.EntityFramework
{
    public class EfArticalDal : GenericRepository<Artical>, IArticalDal
    {
        private readonly ArticalContext _context;
        public EfArticalDal(ArticalContext context) : base(context)
        {
            _context = context;
        }

        public List<Artical> GetArticalsByAuthor(string id)
        {
            var values=_context.Articals.Where(x=>x.AppUserId==id).ToList();
            return values;
        }

        public List<Artical> GetArticalsByCategoryId1()
        {
            var values =_context.Articals.Where(x=>x.CategoryId==1).ToList();
            return values;
        }

        public List<Artical> GetArticalsWithAppUser()
        {
            var values= _context.Articals.Include(x=>x.AppUser).ToList();
            return values;
        }

        public Artical GetArticalsWithAuthorAndCategoriesById(int id)
        {
           var values=_context.Articals.Include(x=>x.AppUser).Include(y=>y.Category).Where(z=>z.ArticalId==id).FirstOrDefault();
            return values;
        }

        public List<Artical> GetArticalsWithCategories()
        {
            return _context.Articals.Include(x=>x.Category).ToList();
        }

        public List<Artical> GetArticalsWithCategoriesAndAppUsers()
        {
            return _context.Articals.Include(x=> x.AppUser).Include(x=>x.Category).ToList();
        }

        public Artical GetBySlug(string slug)
        {
            return _context.Articals
                .Include(x => x.AppUser)
                .Include(x => x.Category)
                .Include(x => x.Comments)
                .FirstOrDefault(x => x.Slug.ToLower() == slug.ToLower());
        }


        public IQueryable<Artical> GetQueryableWithCategories()
        {
         
            return _context.Articals
                .Include(x => x.Category)
                .OrderByDescending(x => x.CreatedDate)
                .AsQueryable();
        }

    }
}

