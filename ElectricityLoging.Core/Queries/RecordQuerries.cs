using ElectricityLoging.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.Core.Queries
{
    public class RecordQuerries : IRecordQuerries
    {
        private readonly AppDbContext dbContext;
        public RecordQuerries(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public PaymentEntry FindLatestRecord()
        {
            var record = dbContext.PaymentEntrys.
                OrderBy(x => x.PaymentDay).
                Select(x => new PaymentEntry()
                {
                    Id = x.Id,
                    PaymentDay = x.PaymentDay,
                    LastMeterNumber = x.LastMeterNumber
                })
                .LastOrDefault();


            return record == null ? new PaymentEntry() : record;
        }
    }
}
