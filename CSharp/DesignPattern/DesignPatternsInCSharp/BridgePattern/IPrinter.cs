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
            Console.WriteLine($"Printing from PC: {context}");
        }
    }

    public class AndroidPrinter : IPrinter
    {
        public void Print(string context)
        {
            Console.WriteLine($"Printing from Android: {context}");
        }
    }

    public abstract class Document
    {
        protected IPrinter _printer;

        protected Document(IPrinter printer)
        {
            _printer = printer;
        }

        public abstract void Print();
    }

    public class PdfDocument : Document
    {
        public PdfDocument(IPrinter printer) : base(printer) { }

        public override void Print()
        {
            _printer.Print("PDF File Content");
        }
    }

    public class WordDocument : Document
    {
        public WordDocument(IPrinter printer) : base(printer) { }

        public override void Print()
        {
            _printer.Print("Word File Content");
        }
    }
}
