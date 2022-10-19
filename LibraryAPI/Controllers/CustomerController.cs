using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static IList<Customer> _customers = new List<Customer>();

        [HttpGet()]
        public IActionResult GetAllCustomers()
        {
            return Ok(_customers);
        }

        [HttpGet("name/{name}")]
        public IActionResult GetCustomerByName(string name)
        {
            var customerExists = _customers.Where(customer => customer.FullName == name);
            if (customerExists.Count() == 0)
            {
                return NotFound();
            } else
            {
                return Ok(customerExists);
            }
        }

        [HttpPost]
        public IActionResult PostCustomer([FromBody] Customer customer)
        {
            _customers.Add(customer);
            return Created($"{nameof(GetCustomerByName)}/{customer.FullName}", customer);
        }

    }
}
