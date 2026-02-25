using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Composition.AmazonOrder
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost();
        string Ship();
    }
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice);
    }
}
