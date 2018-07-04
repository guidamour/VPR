using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Models;
using Vue2Spa.Providers;

namespace Vue2Spa.Controllers.Reports
{
    [Produces("application/json")]
    [Route("api/Reports/6MonthUpdate")]
    public class RegistrantsController : Controller
    {
        private readonly IMonthUpdateProvider _context;

        public RegistrantsController(IMonthUpdateProvider monthUpdate)
        {
            _context = monthUpdate;
        }

        [HttpGet]
        public async Task<IActionResult> Get6MonthUpdateAsync()
        {
            var monthUpdate = await _context.GetMonthUpdate();

            //if (monthUpdate == null)
            //{
            //    return BadRequest();
            //}

            return Ok(Json(monthUpdate));
        }
    }
}
