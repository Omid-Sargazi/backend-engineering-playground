using API_Projects.Application.NewProduct;
using Microsoft.AspNetCore.Mvc;

namespace API_Projects.Controllers.NewProductt
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewProductController:ControllerBase
    {
        private readonly static List<NewProductDto> _newProducts = [];

        public NewProductController()
        {
            
        }

        [HttpPost]
        public ActionResult GetNewProduct([FromBody] NewProductDto newProduct)
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
