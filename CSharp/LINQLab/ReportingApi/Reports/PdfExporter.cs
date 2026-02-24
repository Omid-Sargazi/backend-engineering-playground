using ReportingApi.Abstractions;

namespace ReportingApi.Reports
{
    public class PdfExporter : IReportExporter
    {
        public string Format => "pdf";
        public string Export(string reportData)
        {
            return $"PDF Export: {reportData}";
        }
    }

    public class ExcelExporter : IReportExporter
    {
        public string Format => "excel";

        public string Export(string reportData)
        {
            return $"Excel Export: {reportData}";
        }
    }
}
