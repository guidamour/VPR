using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;

namespace Vue2Spa.Providers
{
    interface IMonthUpdateProvider
    {
        List<MonthUpdateTableHeader> GetMonthUpdate();
    }
}
