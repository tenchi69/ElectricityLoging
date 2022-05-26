using ElectricityLoging.BlazorWeb.Server.Extensions;
using ElectricityLoging.BlazorWeb.Shared.Models;
using ElectricityLoging.Core.Managers;
using ElectricityLoging.Core.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityLoging.BlazorWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentEntryController : Controller
    {
        private readonly IPaymentEntryManager paymentManager;
        private readonly IRecordQuerries querries;

        public PaymentEntryController(IPaymentEntryManager paymentManager, IRecordQuerries querries)
        {
            this.paymentManager = paymentManager;
            this.querries = querries;
        }

        [HttpGet("All")]
        public List<PaymentFormWebModel> GetAll()
        {
            return paymentManager.GetAllEntries().Select(x => x.ToPaymentForm()).ToList();
        }

        [HttpGet("Latest")]
        public PaymentFormWebModel GetLatest()
        {
            return querries.FindLatestRecord().ToPaymentForm();
        }

        [HttpGet("{id}")]
        public PaymentFormWebModel Get(int id)
        {
            return paymentManager.GetById(id).ToPaymentForm();
        }

        [HttpPost]
        public int Post([FromBody] PaymentFormWebModel record)
        {
            return paymentManager.SaveRecord(record.ToPaymentEntry());
        }

    }
}
