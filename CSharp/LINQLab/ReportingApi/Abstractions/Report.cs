namespace ReportingApi.Abstractions
{
    public abstract class Report
    {
        protected readonly IReportExporter _reportExporter;
        protected Report(IReportExporter reportExporter)
        {
            _reportExporter = reportExporter;
        }

        public abstract string Generate();
    }
}
