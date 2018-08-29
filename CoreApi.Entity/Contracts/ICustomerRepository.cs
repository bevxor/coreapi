using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApi.Entity.Model;

namespace CoreApi.Entity.Contracts
{
    public interface ICustomerRepository
    {
        Task CreateAsync(Customer customer);
        Task<bool> DeleteAsync(int customerId);
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int customerId);
        Task UpdateAsync(Customer customer);
    }
}