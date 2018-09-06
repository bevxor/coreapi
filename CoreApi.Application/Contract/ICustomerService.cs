using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApi.Application.Model;

namespace CoreApi.Application.Contract
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int customerId);
        Task CreateAsync(Customer customer);
    }
}