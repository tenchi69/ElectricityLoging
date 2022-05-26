using ElectricityLoging.BlazorWeb.Client.Services;
using ElectricityLoging.BlazorWeb.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace ElectricityLoging.BlazorWeb.Client.Pages.PaymentForm
{
    public partial class Payment
    {
        [Inject]
        public IPaymentEntryService paymentService { get; set; }
        public PaymentFormWebModel recordModel { get; set; }
        private int CreatedId { get; set; } = 5;

        protected override async Task OnInitializedAsync()
        {
            recordModel = await paymentService.GetLatest();
        }

        public async void Save()
        {
            CreatedId = await paymentService.SaveEntry(recordModel) - 1;
        }

        public async void GetById()
        {
            recordModel = await paymentService.GetEntryById(CreatedId);
            StateHasChanged();
        }
    }
}
