using SuperDevices.Base.Entities;
using SuperDevices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SuperDevices.Domain.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        bool IsNull();
        
        T GetById(Guid id);

        Task<T> GetByIdAsync(Guid id);

        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity, string login);

        void Update(T entity, string login);
        bool Exists(Guid id);
        void Remove(T entity);  

        
    }
}
