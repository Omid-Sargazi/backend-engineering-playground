using ReportingApi.Abstractions;

namespace ReportingApi.Reports
{
    public class InventoryReport : Report
    {
        public InventoryReport(IReportExporter exporter)
        : base(exporter) { }
        public override string Generate()
        {
            var data = "Inventory Report Data";
            return _reportExporter.Export(data);
        }
    }
}
