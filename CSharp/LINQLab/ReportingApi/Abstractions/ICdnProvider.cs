namespace ReportingApi.Abstractions
{
    public interface ICdnProvider
    {
        string Name { get; set; }
        string Delivery(string content);
    }
}
