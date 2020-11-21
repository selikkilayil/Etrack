using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ConfigureServices
{
    public static class ConfigureDbServices
    {
        public static IServiceCollection AddMysql(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EtrackDb>(c =>
                                    c.UseMySQL(configuration.GetConnectionString("EtrackTest")));

            return services;
            //Configuration.GetConnectionString("EtrackTest")
        }


        //public static IServiceCollection AddInMemory(this IServiceCollection services)
        //{
        //    services.AddDbContext<EtrackDb>(c =>
        //                            c.UseInMemoryDatabase("testDb"));

        //    return services;
        //    //Configuration.GetConnectionString("EtrackTest")
        //}
    }


    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddMysql(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EtrackDb>(c =>
                                    c.UseMySQL(connectionString));

            return services;
            //Configuration.GetConnectionString("EtrackTest")
        }


        public static IServiceCollection AddInMemory(this IServiceCollection services)
        {
            services.AddDbContext<EtrackDb>(c =>
                                    c.UseInMemoryDatabase("testDb"));

            return services;
            //Configuration.GetConnectionString("EtrackTest")
        }
    }
}
