using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLab.App
{
    public class Orders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }

        public Orders(int id, int customerId, decimal amount)
        {
            Id = id;
            CustomerId = customerId;
            Amount = amount;
        }

    }



    public class OrderReport
    {

        public static void Execute()
        {
            var orders = new List<Orders>
            {
                new(1, 1, 200),
                new(2, 1, 400),
                new(3, 2, 1500),
                new(4, 3, 300),
                new(5, 5, 2500),
                new(6, 6, 700),
            };


            var customers = new List<Customer>
        {
            new (1,"Ali","Tehran",1200),
            new(2,"Sara","Shiraz",3000),
            new(3,"Reza","Tehran",800),
            new(4,"Mina","Tabriz",2500),
            new(5,"Neda","Shiraz",4200),
            new(6,"Hamed","Tehran",1600)
        };

            var orderReport =
            from o in orders
            join c in customers on o.CustomerId equals c.Id
            orderby o.Amount descending
            select new
            {
                OrderId = o.Id,
                CustomerName = c.Name,
                City = c.City,
                Amount = o.Amount
            };

                    foreach (var item in orderReport)
                    {
                        Console.WriteLine($"{item.OrderId} | {item.CustomerName} | {item.City} | {item.Amount}");
                    }

                }
    }
}
