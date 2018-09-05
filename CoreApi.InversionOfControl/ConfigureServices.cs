using CoreApi.Application.Contract;
using Microsoft.Extensions.DependencyInjection;
using CoreApi.Application.Service;
using CoreApi.Common.AppSettings;
using CoreApi.Entity;
using CoreApi.Entity.Contracts;
using CoreApi.Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CoreApi.InversionOfControl
{
    public static class ConfigureServices
    {

        public static void ConfigureInversionOfControl(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

            //Services
            services.AddTransient<ICustomerService, CustomerService>();

            //Repositories
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }

        public static void ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
        }
    }
}
