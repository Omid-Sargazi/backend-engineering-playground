using API_Projects.Application.Orders;
using Microsoft.AspNetCore.Mvc;

namespace API_Projects.Controllers.Orders
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController:ControllerBase
    {
       

        public OrderController()
        {
            
        }

        [HttpPost]
        public ActionResult CreateOrder([FromBody] API_Projects.Models.Order newOrder)
        {
            var result = new API_Projects.Models.Order
            {
                CustomerName = newOrder.CustomerName,
                Items = [new API_Projects.Models.OrderItem { ProductId=1,Quantity=10},
                new API_Projects.Models.OrderItem { ProductId=2,Quantity=2},],
                TotalPrice = newOrder.TotalPrice,
            };
            Data.Orders.Add(result);
            return Ok(result);
        }

        [HttpGet]
        public ActionResult GetOrders()
        {
            return Ok(Data.Orders);
        }
    }
}
