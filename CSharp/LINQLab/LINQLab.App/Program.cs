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
            new(4,"Mina","Tabriz",2500)
        };

        var tehranVipCustomer = customers.Where(c=>c.City=="Tehran" && c.TotalPurchase>1000)
            .Select(c => new {c.Name,c.TotalPurchase}).ToList();

        foreach (var c in tehranVipCustomer)
            Console.WriteLine($"{c.Name} - {c.TotalPurchase}");

    }

    record Customer(int Id, string Name, string City, decimal TotalPurchase);




}