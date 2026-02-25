using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Composition
{
    class Payment
    {
        private readonly IDiscountStrategy discount;
        private readonly ITaxStrategy _tax;

        public Payment(IDiscountStrategy discount, ITaxStrategy tax)
        {
            _discount = discount;
            _tax = tax;
        }

        public decimal Process(decimal amount)
        {
            var discounted = _discount.ApplyDiscount(amount);
            var finalAmount = _tax.ApplyTax(discounted);

            return finalAmount;
        }
    }
}
