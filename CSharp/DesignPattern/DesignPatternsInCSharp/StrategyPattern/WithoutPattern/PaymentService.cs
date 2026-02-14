using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.StrategyPattern.WithoutPattern
{
    public class PaymentService
    {
        public void Pay(string type)
        {
            if(type == "CreditCard")
            {
                Console.WriteLine("Paid by Credit Card");
            }
            else if(type=="P[aypal")
            {
                Console.WriteLine("Paid by Paypal");
            }
            else if(type == "Crypto")
            {
                Console.WriteLine("Paid by Crypto");
            }
        }
    }
}
