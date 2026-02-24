using ReportingApi.Abstractions;
using ReportingApi.Reports;

namespace ReportingApi.Factories
{
    public class ReportFactory : IReportFactory
    {
        private readonly IEnumerable<IReportExporter> _exporters;

        public ReportFactory(IEnumerable<IReportExporter> exporters)
        {
            _exporters = exporters;
        }

        public Report Create(string reportType, string format)
        {
            var exporter = _exporters
                .FirstOrDefault(e => e.Format.Equals(format, StringComparison.OrdinalIgnoreCase));

            if (exporter == null)
                throw new Exception("Invalid export format");

            return reportType.ToLower() switch
            {
                "sales" => new SalesReport(exporter),
                "inventory" => new InventoryReport(exporter),
                _ => throw new Exception("Invalid report type")
            };
        }
    }
}
