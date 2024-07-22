using CRUDProd.Application.Abstraction;
using CRUDProd.Infrostucture.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Infrostucture
{
    public static class InfrostructureDI
    {
        public static IServiceCollection AddInfrostructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IUserDbContext, UserDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("CRUDProd"));
            });

            return services;
        }
    }
}
