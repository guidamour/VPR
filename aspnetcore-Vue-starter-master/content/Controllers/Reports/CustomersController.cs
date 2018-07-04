using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Providers;

namespace Vue2Spa.Controllers.Reports
{
    [Produces("application/json")]
    [Route("api/reports/customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerProvider _context;

        public CustomersController(ICustomerProvider customersUpdate)
        {
            _context = customersUpdate;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _context.GetCustomerUpdate();

            //if (customers == null)
            //{
            //    return NotFound();
            //}

            return Ok(Json(customers));
        }
    }
}
