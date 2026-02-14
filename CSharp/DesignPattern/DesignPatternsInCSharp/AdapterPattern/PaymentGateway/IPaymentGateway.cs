using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AdapterPattern.PaymentGateway
{
    public interface IPaymentGateway
    {
        public void Pay(decimal amount);
    }

    public class StripeService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Stripe Payment Done");
        }
    }

    public class StripeAdapter : IPaymentGateway
    {
        private readonly StripeService _service;
        public StripeAdapter(StripeService service)
        {
            _service = service;
        }
        public void Pay(decimal amount)
        {
            _service.ProcessPayment(amount);
        }
    }
}
