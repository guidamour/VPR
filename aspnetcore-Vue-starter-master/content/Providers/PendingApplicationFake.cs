using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;

namespace Vue2Spa.Providers
{
    public class PendingApplicationFake : IPAProvider
    {
        private readonly List<PendingApplication> _paFake;

        public PendingApplicationFake()
        {
            _paFake = new List<PendingApplication>();
            Initialize();
        }

        private void Initialize()
        {
            _paFake.Add(new PendingApplication()
            {
                Name = "Derek Jones",
                Date = new DateTime(2018,06,11),
                Address = "45 Chambers Avenue, SSM",
                Method = "In-Person"
            });
            _paFake.Add(new PendingApplication()
            {
                Name = "Jeff Munchin",
                Date = new DateTime(2018, 04, 25),
                Address = "2335 Queen Street E., SSM",
                Method = "Paper"
            });
            _paFake.Add(new PendingApplication()
            {
                Name = "Alfred Jimps",
                Date = new DateTime(2018, 11, 23),
                Address = "1415 Queen Street W., SSM",
                Method = "Online"
            });
            _paFake.Add(new PendingApplication()
            {
                Name = "DeeDee Florence",
                Date = new DateTime(2017, 04, 01),
                Address = "154 Third Ave, SSM",
                Method = "Online"
            });
            _paFake.Add(new PendingApplication()
            {
                Name = "Nester Hollingsworth",
                Date = new DateTime(2017, 02, 03),
                Address = "1454 Second Line W., SSM",
                Method = "Online"
            });
        }

        public Task<IEnumerable<PendingApplication>> GetPendingApplication()
        {
            return Task.FromResult(_paFake.AsEnumerable());
        }
    }
}
