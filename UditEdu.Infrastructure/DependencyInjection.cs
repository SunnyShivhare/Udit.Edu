using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Interfaces;
using UditEdu.Core.Options;
using UditEdu.Infrastructure.Data;
using UditEdu.Infrastructure.Repositories;
using UditEdu.Infrastructure.Services;

namespace UditEdu.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>((provider,options) =>
            {
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IExternalVendorRepository, ExternalVendorRepository>();
            services.AddHttpClient<JokeHttpClientService>(
                options =>
                {
                    options.BaseAddress = new Uri("https://official-joke-api.appspot.com/");
                }
                );
            services.AddHttpClient<NationalizeHttpClientService>(
                options=>
                {
                    options.BaseAddress = new Uri("https://api.nationalize.io/");
                });
            return services;
        }
    }
}
