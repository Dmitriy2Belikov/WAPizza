using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WAPizza.Core.Domain.Common;
using WAPizza.Infrastructure;

namespace WAPizza.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationContext>(x => x.UseSqlServer(connectionString));

            services.Scan(x => x
                .FromAssemblies(new List<Assembly>()
                {
                    Assembly.GetAssembly(typeof(ApplicationContext)),
                    Assembly.GetAssembly(typeof(Entity))
                })
                .AddClasses(z => z.InNamespaces(nameof(Infrastructure), nameof(Core)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            return services;
        }
    }
}
