using ElectricityLoging.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.Core.Queries
{
    public interface IRecordQuerries
    {
        public PaymentEntry FindLatestRecord();
    }
}
