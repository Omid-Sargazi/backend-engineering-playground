using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Composition
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal amount);
    }

    public interface ITaxStrategy
    {
        decimal ApplyTax(decimal amount);
    }
}
