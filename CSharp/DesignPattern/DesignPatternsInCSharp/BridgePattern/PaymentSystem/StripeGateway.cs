using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.PaymentSystem
{
    public class StripeGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing {amount} via Stripe");
        }
    }

    public class ZarinpalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing {amount} via Zarinpal");
        }
    }
}
