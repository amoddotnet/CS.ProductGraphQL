using CS.Demo.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zyklus.Shared;

namespace CS.Demo.API.Infrastructure
{
    public static class CyclusServiceCollection
    {
        public static void ServiceDependencyCollection(this IServiceCollection services)
        {
            //Register Services
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IAuthorService, AuthorService>();

            //Register UnitOfWork
            //services.AddTransient<IUnitOfWork, UnitOfWork<CyclusOrderContext>>();

        }
    }
}
