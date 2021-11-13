using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.EF.Entities
{
    public class PaymentEntry
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime PaymentDay { get; set; }
        public decimal ElectricityPrice { get; set; }
        public int LastMeterNumber { get; set; }
        public int CurrentMeterNumber { get; set; }
        public int Difference { get; set; }
        public decimal Debt { get; set; }
        public decimal AmountPayed { get; set; }
    }
}
