using ElectricityLoging.BlazorWeb.Shared.Models;

namespace ElectricityLoging.BlazorWeb.Client.Services
{
    public interface IPaymentEntryService
    {
        public Task<List<PaymentFormWebModel>> GetAllEntries();
        public List<PaymentFormWebModel> GetEntries(PaymentEntrySearchWebModel searchParam);
        public Task<PaymentFormWebModel> GetEntryById(int id);
        public Task<int> SaveEntry(PaymentFormWebModel entry);
        public Task<PaymentFormWebModel> GetLatest();
    }
}
