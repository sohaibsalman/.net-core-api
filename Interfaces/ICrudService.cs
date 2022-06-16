using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICrudService<T>
    {
        Task<T> Create(T model);
        Task<T> Delete(Guid id);
        Task<T> Update(Guid id, T model);
        Task<T> GetById(Guid id);
        Task<T> Get(Expression<Func<T, bool>> filterFunction);
        Task<IEnumerable<T>> List(Func<T, bool> filterFunction = null);
    }
}
