using System.Linq;
using System.Collections.Generic;
using devPartnerTest.Data;
using devPartnerTest.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace devPartnerTest.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public readonly devPartnerContext _context;

        public BaseRepository(devPartnerContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().Select(x => x).AsEnumerable();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges() == 1;
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges() == 1;
        }
    }
}