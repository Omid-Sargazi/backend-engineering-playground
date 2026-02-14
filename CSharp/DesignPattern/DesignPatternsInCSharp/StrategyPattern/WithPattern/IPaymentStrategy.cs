using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.StrategyPattern.WithPattern
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public PayPalPayment()
        {
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Paypal");
        }
    }


    public class CryptoPayment : IPaymentStrategy
    {
        public CryptoPayment()
        {
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Crypto");
        }
    }

    public class PaymentContext
    {
        private readonly IPaymentStrategy _strategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

       public void ExecutePayment(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }

}
