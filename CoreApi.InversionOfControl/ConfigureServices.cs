using System;
using CoreApi.Application.Contract;
using Microsoft.Extensions.DependencyInjection;
using CoreApi.Application.Service;
using CoreApi.Common.AppSettings;
using CoreApi.Common.Contract;
using CoreApi.Entity;
using CoreApi.Entity.Contracts;
using CoreApi.Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Swashbuckle.AspNetCore.Swagger;

namespace CoreApi.InversionOfControl
{
    public static class ConfigureServices
    {

        public static void ConfigureInversionOfControl(this IServiceCollection services , IConfiguration configuration)
        {
            // For Database Server
            //services.AddDbContext<DatabaseContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

            // So i can run it locally or where ever
            services.AddDbContext<DatabaseContext>(options =>
                options.UseInMemoryDatabase("IN memory Test db"));

            //Services
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IAppSettings, AppSettings>();

            //Repositories
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }

        public static void ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<IAppSettings>(configuration.GetSection("AppSettings"));
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(sw =>
                {
                    sw.SwaggerDoc("CoreApi", new Info {Title = "Core Api Demo", Version = "0.1"});
                    sw.IncludeXmlComments(GetXmlCommentsPathForSwagger());
                });
        }

        public static string GetXmlCommentsPathForSwagger()
        {
            return
                System.IO.Path.Combine(
                    System.AppContext.BaseDirectory, "CoreApiSwagger.xml");
        }
    }
}
