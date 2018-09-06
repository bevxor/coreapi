using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApi.Application.Contract;
using CoreApi.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Gets a List of all Customers.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            return await _customerService.GetAllAsync();
        }

        /// <summary>
        /// Gets a Customer from the given Id.
        /// </summary>
        /// <remarks>This API will get the Customer for the given customer id.</remarks>
        /// <param name="customerId"></param>
        [HttpGet("{customerId}")]
        public async Task<ActionResult<Customer>> Get(int customerId)
        {
            return await _customerService.GetByIdAsync(customerId);
        }

        /// <summary>
        /// Creates a Customer in the Database.
        /// </summary>
        [HttpPost]
        public async Task Create([FromBody] Customer customer)
        {
            await _customerService.CreateAsync(customer);
        }

        // PUT api/customer/5
        [HttpPut("{customerId}")]
        public void Put(int customerId, [FromBody] Customer customer)
        {

        }

        // DELETE api/customer/5
        [HttpDelete("{customerId}")]
        public async Task  Delete(int customerId)
        {

        }
    }
}
