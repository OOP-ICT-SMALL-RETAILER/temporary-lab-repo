using Microsoft.AspNetCore.Mvc;
using RetailThingey.Application.Extensions.Buisnesslogic;
using RetailThingey.Application.Models.Product;

namespace RetailThingey.Presentation.Http.Controllers;

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
        public ActionResult<ProductModel> Post(ProductModel productModel)
        {
            _productService.AddProduct(productModel);

            // return CreatedAtAction(, new { id = productModel.Id }, productModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
