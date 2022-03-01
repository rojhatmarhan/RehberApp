using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        RehberContext _context = new RehberContext();

        public void Delete(T p)
        {
            _context.Set<T>().Remove(p);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }
        public void HardDelete(T p)
        {
            _context.Set<T>().Remove(p);
            _context.SaveChanges();
        }

        public int Insert(T p)
        {
            _context.Add(p);
            return _context.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T p)
        {
            _context.Set<T>().Add(p);
        }
    }
}
