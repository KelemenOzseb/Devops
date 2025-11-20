using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<T> where T : class, IIdEntity
    {
        Task<T> Create(T entity);
        Task DeleteById(string id);
        Task<T?> GetOne(string id);
        IQueryable<T> GetAll();
        Task<T> Update(T entity);
    }
}
