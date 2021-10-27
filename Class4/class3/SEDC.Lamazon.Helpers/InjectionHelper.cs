using Microsoft.Extensions.DependencyInjection;
using SEDC.Lamazon.DataAccess;
using SEDC.Lamazon.DataAccess.Implementations;
using SEDC.Lamazon.Domain;
using SEDC.Lamazon.Services.Implementations;
using SEDC.Lamazon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Helpers
{
    public class InjectionHelper
    {
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Product>, ProductRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
