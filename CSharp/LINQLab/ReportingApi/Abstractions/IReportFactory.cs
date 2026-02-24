namespace ReportingApi.Abstractions
{
    public interface IReportFactory
    {
        Report Create(string reportType, string format);
    }
}
