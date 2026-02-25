using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Composition
{
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount;
        }
    }

    public class StandardTax : ITaxStrategy
    {
        public decimal ApplyTax(decimal amount) => amount * 1.2m;
    }
}
