using ReportingApi.Abstractions;

namespace ReportingApi.Exporters
{
    public class PdfExporter : IReportExporter
    {
        public string Export(string reportData)
        {
            return $"PDF Export: {reportData}";
        }
    }

    public class ExcelExporter : IReportExporter
    {
        public string Export(string reportData)
        {
            return $"Excel Export: {reportData}";
        }
    }
}
