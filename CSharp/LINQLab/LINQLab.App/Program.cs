using LINQLab.App;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var customers = new List<Customer>
        {
            new(1,"Ali","Tehran",1200),
            new(2,"Sara","Shiraz",3000),
            new(3,"Reza","Tehran",800),
            new(4,"Mina","Tabriz",2500),
            new(5,"Neda","Shiraz",4200),
            new(6,"Hamed","Tehran",1600)
        };

        var tehranVipCustomer = customers.Where(c=>c.City=="Tehran" && c.TotalPurchase>1000)
            .Select(c => new {c.Name,c.TotalPurchase}).ToList();

        foreach (var c in tehranVipCustomer)
            Console.WriteLine($"{c.Name} - {c.TotalPurchase}");


        var cityReport = customers
    .GroupBy(c => c.City)
    .Select(g => new
    {
        City = g.Key,
        CustomersCount = g.Count(),
        TotalSales = g.Sum(x => x.TotalPurchase),
        AveragePurchase = g.Average(x => x.TotalPurchase)
    })
    .OrderByDescending(x => x.TotalSales)
    .ToList();

        foreach (var item in cityReport)
        {
            Console.WriteLine($"{item.City} | Count: {item.CustomersCount} | Total: {item.TotalSales} | Avg: {item.AveragePurchase}");
        }


    }

    record Customer(int Id, string Name, string City, decimal TotalPurchase);




}