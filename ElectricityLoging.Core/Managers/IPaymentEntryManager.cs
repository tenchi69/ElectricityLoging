using ElectricityLoging.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.Core.Managers
{
    public interface IPaymentEntryManager
    {
        public int SaveRecord(PaymentEntry record);
        public List<PaymentEntry> GetAllEntries();
        public PaymentEntry GetById(int id);
    }
}
