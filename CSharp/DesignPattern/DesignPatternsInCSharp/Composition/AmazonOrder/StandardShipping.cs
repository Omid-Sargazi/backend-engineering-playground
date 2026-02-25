using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Composition.AmazonOrder
{
    public class StandardShipping : IShippingStrategy
    {
        public decimal CalculateShippingCost() => 10;

        public string Ship() => "Shipped via Standard Shipping.";
    }

    public class ExpressShipping : IShippingStrategy
    {
        public decimal CalculateShippingCost() => 25;

        public string Ship() => "Shipped via Express Shipping.";
    }

    public class RegularPricing : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice) => basePrice;
    }

    public class DiscountPricing : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice) => basePrice * 0.9m;
    }
}
