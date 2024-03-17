using Microsoft.AspNetCore.Mvc;
using RetailThingey.Application.Models.Product;
using System.Collections.Generic;

namespace IProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ActionResult<_Product> Post(_Product product)
        {
            _productService.AddProduct(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}