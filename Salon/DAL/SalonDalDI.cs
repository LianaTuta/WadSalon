using Microsoft.Extensions.DependencyInjection;
using Salon.DAL.Repository.Implementation;
using Salon.DAL.Repository.Interface;

namespace Salon.DAL
{
    public static class SalonDalDI
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISalonRepository, SalonRepository>();
            services.AddScoped<ISalonServiceRepository, SalonServiceRepository>();
            services.AddScoped<IUserAccountRepository, UserAccountRepository>();
            return services;
        }
    }
}
