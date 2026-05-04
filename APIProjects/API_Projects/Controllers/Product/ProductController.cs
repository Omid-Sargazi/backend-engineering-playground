using API_Projects.Application.Products.Dtos;
//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace API_Projects.Controllers.Product
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<ProductDto> _products = [];
        private static int _nextId = 1;
        [HttpGet("{id}")]
        public  ActionResult<ProductDto> GetProductById(int id)
        {
                var res =  _products.FirstOrDefault(x => x.Id == id);
            if(res == null)
            {
                return NotFound($" didn`t found a product by id={id}");
            }
            return Ok(res); 
        }
        [HttpGet]
        public ActionResult<List<ProductDto>> GetProducts()
        {

            return Ok(_products);

        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductDto product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }
    }
}
