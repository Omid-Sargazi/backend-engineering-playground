using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AdapterPattern.Payment
{
    public interface IPaymentGateway
    {
        void Pay(decimal amount);
    }

    public class BankAdapter : IPaymentGateway
    {
        private readonly OldBankSystem _bankSystem;
        public BankAdapter(OldBankSystem oldBankSystem) 
        {
            _bankSystem = oldBankSystem;
        }
        public void Pay(decimal amount)
        {
            _bankSystem.MakeTransaction(amount);
        }
    }
}
