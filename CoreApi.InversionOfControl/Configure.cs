using CoreApi.Application.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;
using CoreApi.Application.Service;
using CoreApi.Entity.Contracts;
using CoreApi.Entity.Repositories;

namespace CoreApi.InversionOfControl
{
    public class Configure
    {

        public void ConfigureInversionOfControl(IServiceCollection servicesCollection)
        {
            //Services
            servicesCollection.AddTransient<ICustomerService, CustomerService>();

            //Repositories
            servicesCollection.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}
