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

    public abstract class Payment
    {
        protected IPaymentGateway _gateway;

        protected Payment(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public abstract void Pay(decimal amount);
    }

    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(IPaymentGateway gateway)
            : base(gateway) { }

        public override void Pay(decimal amount)
        {
            Console.WriteLine("Validating Credit Card...");
            _gateway.ProcessPayment(amount);
        }
    }

    public class CryptoPayment : Payment
    {
        public CryptoPayment(IPaymentGateway gateway)
            : base(gateway) { }

        public override void Pay(decimal amount)
        {
            Console.WriteLine("Validating Crypto Wallet...");
            _gateway.ProcessPayment(amount);
        }
    }
}
