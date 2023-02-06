using Microsoft.EntityFrameworkCore;
using SuperDevices.Base.Entities;
using SuperDevices.DataAccess.Context;
using SuperDevices.Domain.Entities;
using SuperDevices.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDevices.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool IsNull()
        {
            if (_context.Set<T>() == null)
                return true;
            //if (!_context.Devices.Any())
            //return true;
            return false;
        }

        
        public void Add(T entity, string login)
        {
            entity.Version = 1;
            var dateNow = DateTime.Now;
            entity.DateCreate = dateNow;
            entity.Creator = login;
            entity.DateEdit = dateNow;
            entity.Editor = login;
            _context.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
        

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var list = await _context.Set<T>().ToListAsync();
            return list;
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var obj = await _context.Set<T>().FirstOrDefaultAsync<T>(m => m.Id == id);
            return obj;

        }

        public void Update(T entity, string login)
        {
            entity.Version++;
            entity.DateEdit = DateTime.Now;
            entity.Editor = login;
            _context.Set<T>().Update(entity);
        }

        public bool Exists(Guid id)
        {
            var result = _context.Set<T>().Any(e => e.Id == id);
            return result;
        }



        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

    }
}
