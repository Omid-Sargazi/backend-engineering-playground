using ReportingApi.Abstractions;

namespace ReportingApi.Reports
{
    public class SalesReport : Report
    {
        public SalesReport(IReportExporter exporter)
        : base(exporter) { }
        public override string Generate()
        {
            var data = "Sales Report Data";
            return _reportExporter.Export(data);
        }
    }
}
