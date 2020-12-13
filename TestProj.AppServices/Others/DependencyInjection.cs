using Microsoft.Extensions.DependencyInjection;
using TestProj.AppServices.AppServices;
using TestProj.AppServices.Interfaces;
using TestProj.Data.Data;
using TestProj.Data.Interfaces;

namespace TestProj.AppServices.Others
{
    public static class DependencyInjection
    {
        public static void AddProjectServicesAndRepositoresDependencyInjection(this IServiceCollection services)
        {

            //Services
            services.AddTransient<IProductService, ProductService>();

            //Data
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
