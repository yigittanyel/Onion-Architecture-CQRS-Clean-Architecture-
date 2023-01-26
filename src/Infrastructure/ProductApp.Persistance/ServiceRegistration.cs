using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Abstraction.Repository;
using ProductApp.Persistance.Context;
using ProductApp.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistance
{
    public static class ServiceRegistration
    {

        public static void AddPersistanceService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memory"));
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }

    }
}
