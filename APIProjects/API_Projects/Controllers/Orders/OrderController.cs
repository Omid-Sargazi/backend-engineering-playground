using API_Projects.Application.Orders;
using Microsoft.AspNetCore.Mvc;

namespace API_Projects.Controllers.Orders
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController:ControllerBase
    {
        private readonly static List<OrderDto> _newProducts = [];

        public OrderController()
        {
            
        }

        [HttpPost]
        public ActionResult GetNewProduct([FromBody] OrderDto newProduct)
        {
            _newProducts.Add(newProduct);
            return Ok(newProduct);
        }

        [HttpGet]
        public ActionResult GetNewProducts()
        {
            return Ok(_newProducts);
        }
    }
}
