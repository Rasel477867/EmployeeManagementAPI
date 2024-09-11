using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Repository.Core
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task Update(T Entity);
        Task Delete(T Entity);
        Task Add(T Entity);
        Task DeleteRangeFromDBAsync(IEnumerable<T> entities);
        Task AddRangeAsync(IEnumerable<T> entities);

    }
}
