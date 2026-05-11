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
        public ActionResult CreateOrder([FromBody] API_Projects.Models.Dtos.OrderDto newOrder)
        {
           if(newOrder.CustomerName== null || newOrder.CustomerName=="")
            {
                return BadRequest("CustomerName must be fill suitable name");
            }
          if(newOrder.Quantity <= 0)
            {
                return BadRequest("Qyt msut be greater than 0");
            }
            
          
            decimal totalPrice = 0;
            var orderItems = new List<API_Projects.Models.OrderItem>();

            foreach(var item in newOrder.Items)
            {
                if(item.Quantity<=0)
                {
                    return BadRequest("Quantity must be greater than 0");
                }

                var product = Data.Products.FirstOrDefault(p=>p.Id == item.ProductId);
                if(product == null)
                {
                    return BadRequest($"Product with id{item.ProductId} not found");
                }

                totalPrice += product.Price * item.Quantity;
                orderItems.Add(new Models.OrderItem
                {
                    Quantity = item.Quantity,
                    ProductId = item.ProductId,
                });

            }
                return Ok(orderItems);

           
        }

        [HttpGet]
        public ActionResult GetOrders()
        {
            return Ok(Data.Orders);
        }
    }
}
