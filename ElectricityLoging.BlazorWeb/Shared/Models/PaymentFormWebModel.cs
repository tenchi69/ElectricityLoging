using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.BlazorWeb.Shared.Models
{
    public class PaymentFormWebModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime PaymentDay { get; set; }
        public decimal ElectricityPrice { get; set; }
        public int LastMeterNumber { get; set; }
        public int CurrentMeterNumber { get; set; }
        public int Difference
        {
            get
            {
                return CurrentMeterNumber == 0 ? 0 : CurrentMeterNumber - LastMeterNumber;
            }
            set
            {
            }
        }
        public decimal Debt
        {
            get
            {
                return Difference * ElectricityPrice;
            }
            set
            {
            }
        }
        public decimal AmountPayed { get; set; }

        public PaymentFormWebModel()
        {
            DateCreated = DateTime.Now;
            PaymentDay = DateTime.Now;
        }
    }
}
