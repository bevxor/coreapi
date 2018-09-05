using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApi.Application.Contract;
using CoreApi.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET api/customer
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            return await _customerService.GetAll();
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/customer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
