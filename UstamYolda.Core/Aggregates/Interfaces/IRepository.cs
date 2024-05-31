using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstamYolda.Core.Aggregates.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> ListAsync();
        Task<T> GetById(Guid id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
    }
}
