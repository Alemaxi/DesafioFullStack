using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFullStack.Domain
{
    public interface IBaseService<T>
    {
        Task<T> Insert(T obj);
        Task<T> Update(T obj);
        Task<bool> Delete(int id);
        Task<T> Select(int id);
        Task<IEnumerable<T>> SelectAll();
    }
}
