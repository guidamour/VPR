using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;

namespace Vue2Spa.Providers
{
    public class CustomerUpdateFake : ICustomerProvider
    {
        private readonly List<Customer> _customersFake;

        public CustomerUpdateFake()
        {
            _customersFake = new List<Customer>();
            Initialize();
        }

        private void Initialize()
        {
            this._customersFake.Add(new Customer()
            {
                Name = "Maisie",
                Phone = "1-381-624-3954",
                Email = "luctus@eteuismodet.edu",
                StreetAddress = "167 Odio Ave",
                City = "Polcenigo",
                PostalCode = "87346",
                Country = "United States"
            });
            _customersFake.Add(new Customer()
            {
                Name = "Chaim",
                Phone = "1-907-465-3422",
                Email = "nec.tellus@necanteblandit.com",
                StreetAddress = "739 Nisl. Rd.",
                City = "Sint-Kruis-Winkel",
                PostalCode = "04117",
                Country = "Madagascar"
            });
            _customersFake.Add(new Customer()
            {
                Name = "Arthur",
                Phone = "1-608-858-6075",
                Email = "gravida.non.sollicitudin@Aeneaneget.co.uk",
                StreetAddress = "603-4716 Malesuada Rd.",
                City = "Palencia",
                PostalCode = "Y6R 0N3",
                Country = "Latvia"
            });
            _customersFake.Add(new Customer()
            {
                Name = "Vladimir",
                Phone = "1-689-886-0593",
                Email = "neque@arcuiaculisenim.org",
                StreetAddress = "6299 Suspendisse Street",
                City = "Navsari",
                PostalCode = "878274",
                Country = "Paraguay"
            });
            _customersFake.Add(new Customer()
            {
                Name = "Trevor",
                Phone = "1-481-467-3610",
                Email = "convallis@malesuadafames.co.uk",
                StreetAddress = "8290 Arcu Avenue",
                City = "Joondalup",
                PostalCode = "71019",
                Country = "Canada"
            });
            _customersFake.Add(new Customer()
            {
                Name = "Kelly",
                Phone = "1-839-371-9826",
                Email = "velit.eu.sem@auctorodio.com",
                StreetAddress = "860-326 Dictum St.",
                City = "Sint-Lambrechts-Woluwe",
                PostalCode = "J9B 9M1",
                Country = "Puerto Rico"
            });
        }

        public Task<IEnumerable<Customer>> GetCustomerUpdate()
        {
            return Task.FromResult(_customersFake.AsEnumerable());
        }
    }
}
