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
    [Route("api/reports/pendingapplications")]
    public class PAController : Controller
    {
        private readonly IPAProvider _context;

        public PAController(IPAProvider pendingA)
        {
            _context = pendingA;
        }

        [HttpGet]
        public async Task<IActionResult> GetPendingApplication()
        {
            var pendingApplicationUpdate = await _context.GetPendingApplication();

            if (pendingApplicationUpdate.ToList().Count < 1)
            {
                return BadRequest();
            }

            return Ok(Json(pendingApplicationUpdate));
        }
    }
}
