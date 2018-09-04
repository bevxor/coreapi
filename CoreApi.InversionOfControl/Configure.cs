using CoreApi.Application.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;
using CoreApi.Application.Service;
using CoreApi.Entity;
using CoreApi.Entity.Contracts;
using CoreApi.Entity.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.InversionOfControl
{
    public class Configure
    {

        public void ConfigureInversionOfControl(IServiceCollection servicesCollection)
        {
            servicesCollection.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(@"Server=topnz17943;Database=CoreApi;User ID=coreapiuser;Password=Welcome1;"));
            //Services
            servicesCollection.AddTransient<ICustomerService, CustomerService>();

            //Repositories
            servicesCollection.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}
