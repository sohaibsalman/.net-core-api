using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICrudService<T>
    {
        Task<IEnumerable<T>> List(Func<T, bool> filterFunction = null);
        Task<T> Create(T model);
        Task<T> Delete(Guid id);
        Task<T> Update(Guid id, T model);
    }
}
