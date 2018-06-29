using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers.Reports
{
    [Produces("application/json")]
    [Route("api/Reports")]
    public class ReportsController : Controller
    {
        [HttpGet]
        public IActionResult Get6MonthUpdate()
        {
            string [,] Header = new string[,]{
                { "Name", "Name"},
                { "Date", "Date"},
                { "Text", "Text"},
                { "State", "State"}
            };

            string[,] content = new string[,]
            {

            };
            var result = new
            {
                Headers = Header,
                Forecasts = content
            };

            return Ok(result);
        }
    }
}
