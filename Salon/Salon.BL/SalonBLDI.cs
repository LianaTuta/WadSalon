using Microsoft.Extensions.DependencyInjection;
using Salon.BL.Services.Implementation;
using Salon.BL.Services.Interface;
using Salon.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.BL
{
  
    public static class SalonBLDI
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ISalonService, SalonsService>();
            services.AddTransient<ISalonServicesService, SalonServicesService>();
            services.AddTransient<IUserAccountService, UserAcconuntService>();
            return services;
        }
    }
}
