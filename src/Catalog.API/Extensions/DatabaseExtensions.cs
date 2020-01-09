using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.API.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddCatalogContext(this IServiceCollection services)
        {
            return services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<CatalogContext>(contextOptions =>
                {
                    contextOptions.UseSqlServer(
                        "Server=localhost,1433;Initial Catalog=Store;User Id =<SA_USER>; Password =<PASSWORD>",
                        serverOptions => { serverOptions.MigrationsAssembly(typeof(Startup).Assembly.FullName); });
                });
        }
    }
}
