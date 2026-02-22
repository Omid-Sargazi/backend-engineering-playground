using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.ReportingEngine
{
    public interface IReportExporter
    {
        void Export(string reportData);
    }

    public class PdfExporter : IReportExporter
    {
        public void Export(string reportData)
        {
            Console.WriteLine("Exporting report as PDF");
        }
    }

    public class ExcelExporter : IReportExporter
    {
        public void Export(string reportData)
        {
            Console.WriteLine("Exporting report as Excel");
        }
    }
}
