using ElectricityLoging.BlazorWeb.Shared.Models;

namespace ElectricityLoging.BlazorWeb.Client.Pages.PaymentForm
{
    public partial class Payment
    {
        public PaymentFormWebModel recordModel { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {

        }
    }
}
