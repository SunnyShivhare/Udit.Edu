using UditEdu.Application;
using UditEdu.Core;
using UditEdu.Infrastructure;

namespace UditEdu.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddApplicationDI().AddInfrastructureDI().AddCoreDI(configuration);  
            return services;
        }
    }
}
