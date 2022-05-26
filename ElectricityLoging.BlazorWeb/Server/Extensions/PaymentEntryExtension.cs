using ElectricityLoging.BlazorWeb.Shared.Models;
using ElectricityLoging.EF.Entities;

namespace ElectricityLoging.BlazorWeb.Server.Extensions
{
    public static class PaymentEntryExtension
    {
        public static PaymentFormWebModel ToPaymentForm(this PaymentEntry entry)
        {
            PaymentFormWebModel model = new PaymentFormWebModel();

            model.Id = entry.Id;
            model.Difference = entry.Difference;
            model.DateCreated = entry.DateCreated;
            model.PaymentDay = entry.PaymentDay;
            model.AmountPayed = entry.AmountPayed;
            model.CurrentMeterNumber = entry.CurrentMeterNumber;
            model.Debt = entry.Debt;
            model.Difference = entry.Difference;
            model.ElectricityPrice = entry.ElectricityPrice;
            model.LastMeterNumber = entry.LastMeterNumber;
            
            return model;
        }
    }
}
