using DataAccess;
using DataAccess.Implementations;
using Domain.Domain;
using Microsoft.Extensions.DependencyInjection;
using Services.Implementation;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public class InjectionHelper
    {
        public static void InjectRepositories( IServiceCollection service)
        {
            service.AddTransient<IRepository<Product>, ProductRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IProductServices, ProductService>();
        }
    }
}
