using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vue2Spa.Models
{
    public class PendingApplication
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Method { get; set; }
    }
}
