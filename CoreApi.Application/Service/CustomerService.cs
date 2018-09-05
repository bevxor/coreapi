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

        public async Task<List<Customer>> GetAll()
        {
            var customerList =
                await _customerRepository.GetAllAsync();

            return _mapper.Map<List<Customer>>(customerList);
        }

    }
}