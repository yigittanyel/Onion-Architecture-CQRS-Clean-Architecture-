using ProductApp.Domain.Entities;
using ProductApp.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Abstraction.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetPByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}
