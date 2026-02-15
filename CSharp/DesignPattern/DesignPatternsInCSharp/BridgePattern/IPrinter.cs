using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern
{
    public interface IPrinter
    {
        void Print(string context);
    }

    public class PCPrinter : IPrinter
    {
        public void Print(string context)
        {
            Console.WriteLine($"Printing from PC: {content}");
        }
    }

    public class AndroidPrinter : IPrinter
    {
        public void Print(string context)
        {
            Console.WriteLine($"Printing from Android: {content}");
        }
    }
}
