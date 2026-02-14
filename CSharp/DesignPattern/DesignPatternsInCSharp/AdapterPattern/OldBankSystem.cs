using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AdapterPattern
{
    public class OldBankSystem
    {
        public void MakeTransaction(decimal money)
        {
            Console.WriteLine($"Paid {money} using Old Bank System");
        }
    }
}
