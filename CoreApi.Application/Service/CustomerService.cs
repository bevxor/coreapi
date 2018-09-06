using CoreApi.Application.Model;
using CoreApi.Entity.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CoreApi.Application.Contract;

namespace CoreApi.Application.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            var customerList =
                await _customerRepository.GetAllAsync();

            return _mapper.Map<List<Customer>>(customerList);
        }

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            var customerList =
                await _customerRepository.GetByIdAsync(customerId);

            return _mapper.Map<Customer>(customerList);
        }

        public async Task CreateAsync(Customer customer)
        {
            var customerEntity =
                _mapper.Map<Entity.Model.Customer>(customer);

            await _customerRepository.CreateAsync(customerEntity);
        }
    }
}