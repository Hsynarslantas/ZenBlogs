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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly ArticalContext _context;
        public EfCommentDal(ArticalContext context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetCommentsByArticalsId(int id)
        {
            var values = _context.Comments
                .Include(y => y.AppUser)        // Kullanıcının bilgilerini dahil et
                .Include(y => y.Artical)        // İstersen makale bilgisini de dahil et
                .Where(x => x.ArticalId == id)  // Makale ID'sine göre filtrele
                .ToList();

            return values;
        }

    }
}
