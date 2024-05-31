using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UstamYolda.DependencyInjection
{
    public static class ServicesCollectionExtention
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {

            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

             //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }

    }
}
