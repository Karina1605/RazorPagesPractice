using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPages.Repo
{
    public interface ICrud<T>
    {
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<T> Delete(T item);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
