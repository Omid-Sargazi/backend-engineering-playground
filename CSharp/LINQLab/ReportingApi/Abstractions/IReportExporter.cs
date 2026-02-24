namespace ReportingApi.Abstractions
{
    public interface IReportExporter
    {
        string Format { get; }

        string Export(string reportData);
       
    }
}
