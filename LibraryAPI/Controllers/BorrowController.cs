using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BorrowController : ControllerBase
    {
        private static IList<Borrow> _borrows = new List<Borrow>();

        [HttpGet()]
        public IActionResult GetAllBorrows()
        {
            return Ok(_borrows);
        }

        /*[HttpGet("name/{name}")]
        public IActionResult GetBorrowByCustomerId(int id)
        {
        }

        [HttpPost]
        public IActionResult PostBorrow([FromBody] Borrow borrow)
        {
            _borrows.Add(borrow);
            return Created($"{nameof(GetBorrowBy)}/{customer.FullName}", customer);
        }*/

    }
}
