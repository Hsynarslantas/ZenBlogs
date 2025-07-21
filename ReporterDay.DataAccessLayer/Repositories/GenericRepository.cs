using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReporterDay.DataAccessLayer.Abstract;
using ReporterDay.DataAccessLayer.Context;

namespace ReporterDay.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly ArticalContext _context;

        public GenericRepository(ArticalContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
