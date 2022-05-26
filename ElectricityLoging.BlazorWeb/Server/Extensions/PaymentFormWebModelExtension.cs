using ElectricityLoging.BlazorWeb.Shared.Models;
using ElectricityLoging.EF.Entities;

namespace ElectricityLoging.BlazorWeb.Server.Extensions
{
    public static class PaymentFormWebModelExtension
    {
        public static PaymentEntry ToPaymentEntry(this PaymentFormWebModel model)
        {
            PaymentEntry entry = new();

            entry.Id = model.Id;
            entry.AmountPayed = model.AmountPayed;
            entry.PaymentDay = model.PaymentDay;
            entry.CurrentMeterNumber = model.CurrentMeterNumber;
            entry.DateCreated = model.DateCreated;
            entry.Debt  = model.Debt;
            entry.Difference = model.Difference;
            entry.ElectricityPrice = model.ElectricityPrice;
            entry.LastMeterNumber = model.LastMeterNumber;
            entry.DateCreated = model.DateCreated;

            return entry;
        }
    }
}
