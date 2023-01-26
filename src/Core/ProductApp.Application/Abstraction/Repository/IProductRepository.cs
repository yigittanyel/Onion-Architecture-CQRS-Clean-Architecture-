using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Abstraction.Repository
{
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {

    }
}
