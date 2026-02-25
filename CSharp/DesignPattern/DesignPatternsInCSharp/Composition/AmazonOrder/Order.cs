using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Composition.AmazonOrder
{
    public class Order
    {
        private readonly IPaymentStrategy _paymentStrategy;
        private readonly IShippingStrategy _shippingStrategy;
        private readonly IPricingStrategy _pricingStrategy;

        public Order(
            IPaymentStrategy paymentStrategy,
            IShippingStrategy shippingStrategy,
            IPricingStrategy pricingStrategy)
        {
            _paymentStrategy = paymentStrategy;
            _shippingStrategy = shippingStrategy;
            _pricingStrategy = pricingStrategy;
        }

        public void ProcessOrder(decimal basePrice)
        {
            var finalPrice = _pricingStrategy.CalculatePrice(basePrice);
            var shippingCost = _shippingStrategy.CalculateShippingCost();
            var total = finalPrice + shippingCost;

            Console.WriteLine($"Final Price: {finalPrice}");
            Console.WriteLine($"Shipping Cost: {shippingCost}");
            Console.WriteLine($"Total: {total}");

            _paymentStrategy.Pay(total);

            Console.WriteLine(_shippingStrategy.Ship());
        }
    }
}
