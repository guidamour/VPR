using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Vue2Spa.Models;

namespace Vue2Spa.Providers
{
    public class MonthUpdateFake : IMonthUpdateProvider
    {
        private readonly List<MonthUpdateTableHeader> _monthUpdates;

        public MonthUpdateFake()
        {
            _monthUpdates = new List<MonthUpdateTableHeader>();
            Initialize();
        }

        private void Initialize()
        {
            this._monthUpdates.Add(new MonthUpdateTableHeader()
            {
                Name = "Greg Rakozy",
                Date = new DateTime(2018, 6, 1),
                Text = "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                State = "Active"
            });

            this._monthUpdates.Add(new MonthUpdateTableHeader()
            { 
                Name = "Paula Diorza",
                Date = new DateTime(2016, 12, 15),
                Text = "Ad homero efficiantur usu, ut sed essent maiorum.",
                State = "Active"
            });
            this._monthUpdates.Add(new MonthUpdateTableHeader()
            {
                Name = "Jeffery D'Amidio",
                Date = new DateTime(2017, 10, 23),
                Text = "In sea porro temporibus.",
                State = "Active"
            });
            this._monthUpdates.Add(new MonthUpdateTableHeader()
            {
                Name = "Lawrence Dorence",
                Date = new DateTime(2017, 4, 1),
                Text = "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                State = "Active"
            });
            this._monthUpdates.Add(new MonthUpdateTableHeader()
            {
                Name = "Daniel Nog",
                Date = new DateTime(2017, 2, 13),
                Text = "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                State = "Active"
            });
            this._monthUpdates.Add(new MonthUpdateTableHeader()
            {
                Name = "Greg Rakozy",
                Date = new DateTime(2018, 1, 12),
                Text = "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                State = "Active"
            });
        }
        
        public Task<IEnumerable<MonthUpdateTableHeader>> GetMonthUpdate()
        {
            return Task.FromResult(_monthUpdates.AsEnumerable());
        }
    }
}
