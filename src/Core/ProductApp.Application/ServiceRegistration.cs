using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationeService(this IServiceCollection serviceCollection)
        {
            var ass = Assembly.GetExecutingAssembly();
            serviceCollection.AddMediatR(ass);
            serviceCollection.AddAutoMapper(ass);
        }
    }
}
