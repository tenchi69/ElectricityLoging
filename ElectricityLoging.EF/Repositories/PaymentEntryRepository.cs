using ElectricityLoging.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityLoging.EF.Repositories
{
    public class PaymentEntryRepository : IGenericRepository<PaymentEntry>
    {
        private readonly AppDbContext dbContext;

        public PaymentEntryRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            var entity = dbContext.PaymentEntrys.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                dbContext.PaymentEntrys.Remove(entity);
            }
        }

        public PaymentEntry Get(int id)
        {
            return dbContext.PaymentEntrys.FirstOrDefault(e => e.Id == id);
        }

        public List<PaymentEntry> GetAll()
        {
            return dbContext.PaymentEntrys.ToList();
        }

        public void Save(PaymentEntry entity)
        {
            dbContext.Add(entity);
        }
    }
}
