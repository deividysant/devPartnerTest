using System.Linq;
using System.Collections.Generic;
using devPartnerTest.Data;
using devPartnerTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace devPartnerTest.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly devPartnerContext _context;

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
            var verify = GetById(entity.Id);

            if(verify is null) return false;

            _context.Set<T>().Update(entity);
            return _context.SaveChanges() == 1;
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            if(entity is null) return false;
            
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges() == 1;
        }
    }
}