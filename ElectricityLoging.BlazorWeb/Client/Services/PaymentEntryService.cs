using ElectricityLoging.BlazorWeb.Shared.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ElectricityLoging.BlazorWeb.Client.Services
{
    public class PaymentEntryService : IPaymentEntryService
    {
        private readonly HttpClient httpClient;

        public PaymentEntryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public HttpClient HttpClient { get; }

        public async Task<List<PaymentFormWebModel>> GetAllEntries()
        {
            return await JsonSerializer.DeserializeAsync<List<PaymentFormWebModel>>(await httpClient.GetStreamAsync($"api/PaymentEntry/All"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public List<PaymentFormWebModel> GetEntries(PaymentEntrySearchWebModel searchParam)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentFormWebModel> GetEntryById(int id)
        {
            return await JsonSerializer.DeserializeAsync<PaymentFormWebModel>(await httpClient.GetStreamAsync($"api/PaymentEntry/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<int> SaveEntry(PaymentFormWebModel entry)
        {
            var content = new StringContent(JsonSerializer.Serialize(entry),Encoding.UTF8, "application/json");
            var responce = await httpClient.PostAsync("api/PaymentEntry", content);
            return JsonSerializer.Deserialize<int>(responce.Content.ReadAsStringAsync().Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = false }); 
        }

        public async Task<PaymentFormWebModel> GetLatest()
        {
            return await JsonSerializer.DeserializeAsync<PaymentFormWebModel>(await httpClient.GetStreamAsync($"api/PaymentEntry/Latest"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
