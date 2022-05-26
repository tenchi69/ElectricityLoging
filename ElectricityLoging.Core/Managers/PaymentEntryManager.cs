using ElectricityLoging.EF.Entities;
using ElectricityLoging.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.Core.Managers
{
    public class PaymentEntryManager : IPaymentEntryManager
    {
        private readonly AppDbContext dbContext;
        private readonly IGenericRepository<PaymentEntry> entryRepository;

        public PaymentEntryManager(AppDbContext dbContext, IGenericRepository<PaymentEntry> entryRepository)
        {
            this.dbContext = dbContext;
            this.entryRepository = entryRepository;
        }

        public List<PaymentEntry> GetAllEntries()
        {
            return entryRepository.GetAll();
        }

        public PaymentEntry GetById(int id)
        {
            return entryRepository.Get(id);
        }

        public int SaveRecord(PaymentEntry record)
        {
            entryRepository.Save(record);
            dbContext.SaveChanges();
            return record.Id;
        }
    }
}
