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

    public abstract class Report
    {
        protected IReportExporter _exporter;

        protected Report(IReportExporter exporter)
        {
            _exporter = exporter;
        }

        public abstract void Generate();
    }

    public class SalesReport : Report
    {
        public SalesReport(IReportExporter exporter)
            : base(exporter) { }

        public override void Generate()
        {
            Console.WriteLine("Generating sales report data...");
            _exporter.Export("Sales Data");
        }
    }

    public class InventoryReport : Report
    {
        public InventoryReport(IReportExporter exporter)
            : base(exporter) { }

        public override void Generate()
        {
            Console.WriteLine("Generating inventory report data...");
            _exporter.Export("Inventory Data");
        }
    }
}
