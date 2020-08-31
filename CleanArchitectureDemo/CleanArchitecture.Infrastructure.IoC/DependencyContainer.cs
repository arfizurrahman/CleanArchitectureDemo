using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // CleanArchitecture.Application
            services.AddScoped<IBookService, BookService>();

            // CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
