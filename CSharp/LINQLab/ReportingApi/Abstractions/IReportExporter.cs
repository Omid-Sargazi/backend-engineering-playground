namespace ReportingApi.Abstractions
{
    public interface IReportExporter
    {
        string Export(string reportData);
       
    }
}
