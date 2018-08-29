using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApi.Application.Model;

namespace CoreApi.Application.Contract
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
    }
}