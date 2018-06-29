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
        private List<MonthUpdateTableHeader> MonthUpdates { get; set; }

        public MonthUpdateFake()
        {
            Initialize();
        }

        private void Initialize()
        {
            MonthUpdates[0] = new MonthUpdateTableHeader
            {
                Name = "Greg Rakozy",
                Date = new DateTime(2018, 6, 1),
                Text = "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                State = "Active"
            };
            MonthUpdates[1] = new MonthUpdateTableHeader
            {
                Name = "Paula Diorza",
                Date = new DateTime(2016, 12, 15),
                Text = "Ad homero efficiantur usu, ut sed essent maiorum.",
                State = "Active"
            };
            MonthUpdates[2] = new MonthUpdateTableHeader
            {
                Name = "Jeffery D'Amidio",
                Date = new DateTime(2017, 10,23),
                Text = "In sea porro temporibus.",
                State = "Active"
            };
            MonthUpdates[3] = new MonthUpdateTableHeader
            {
                Name = "Lawrence Dorence",
                Date = new DateTime(2017, 4, 1),
                Text = "Id vix saepe impetus ceteros, te simul essent rationibus sed, facilis voluptua qui id.",
                State = "Active"
            };
            MonthUpdates[4] = new MonthUpdateTableHeader
            {
                Name = "Daniel Nog",
                Date = new DateTime(2017, 2, 13),
                Text = "Cu vis dicit nominavi pericula, his urbanitas scripserit ad, te cum possit interesset referrentur.",
                State = "Active"
            };
            MonthUpdates[5] = new MonthUpdateTableHeader
            {
                Name = "Greg Rakozy",
                Date = new DateTime(2018, 1, 12),
                Text = "Lorem ipsum dolor sit amet, aliquam fabulas denique",
                State = "Active"
            };

        }

        public List<MonthUpdateTableHeader> GetMonthUpdate()
        {
            return MonthUpdates;
        }
    }
}
