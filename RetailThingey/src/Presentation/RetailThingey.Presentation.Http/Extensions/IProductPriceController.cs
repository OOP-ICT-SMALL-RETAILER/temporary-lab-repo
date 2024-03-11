using Microsoft.AspNetCore.Mvc;

namespace IProductPrice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductPriceController : ControllerBase
    {
        private readonly IProductPriceService _productPriceService;

        public ProductPriceController(IProductPriceService productPriceService)
        {
            _productPriceService = productPriceService;
        }

        [HttpPost("increase/{productId}")]
        public ActionResult IncreasePrice(int productId, decimal amount)
        {
            _productPriceService.IncreasePrice(productId, amount);
            return Ok();
        }

        [HttpPost("decrease/{productId}")]
        public ActionResult DecreasePrice(int productId, decimal amount)
        {
            _productPriceService.DecreasePrice(productId, amount);
            return Ok();
        }
    }
}