using Microsoft.AspNetCore.Mvc;
using ReportingApi.Abstractions;
using ReportingApi.Exporters;
using ReportingApi.Reports;

namespace ReportingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;

        public ReportsController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpGet]
        public IActionResult GetReport(string type, string format)
        {
            IReportExporter exporter = format.ToLower() switch
            {
                "pdf" => _serviceProvider.GetRequiredService<PdfExporter>(),
                "excel" => _serviceProvider.GetRequiredService<ExcelExporter>(),
                _ => throw new Exception("Invalid format")
            };

            Report report = type.ToLower() switch
            {
                "sales" => new SalesReport(exporter),
                "inventory" => new InventoryReport(exporter),
                _ => throw new Exception("Invalid report type")
            };

            var result = report.Generate();
            return Ok(result);
        }
    }
}
