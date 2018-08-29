using CoreApi.Application.Model;
using CoreApi.Entity.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApi.Application.Contract;

namespace CoreApi.Application.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> GetAll()
        {
            var customerList =
                await _customerRepository.GetAllAsync();

            //TODO Wire Up AutoMapper
            var list = new List<Customer>();

            foreach (var customer in customerList)
            {
                list.Add(
                    new Customer
                    {
                        CustomerId = customer.CustomerId,
                        FirstName = customer.FirstName,
                        Surname = customer.FirstName
                    });
            }

            return list;
        }

    }
}