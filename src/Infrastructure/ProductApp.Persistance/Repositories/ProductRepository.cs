using ProductApp.Application.Abstraction.Repository;
using ProductApp.Domain.Entities;
using ProductApp.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistance.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

    }
}
