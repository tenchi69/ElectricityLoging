using ElectricityLoging.BlazorWeb.Client.Services;
using ElectricityLoging.BlazorWeb.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace ElectricityLoging.BlazorWeb.Client.Pages.ListOfPayments
{
    public partial class ListOfPayments
    {
        [Inject]
        public IPaymentEntryService paymentService { get; set; }
        public List<PaymentFormWebModel> records { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            records = await paymentService.GetAllEntries();
        }
    }
}
