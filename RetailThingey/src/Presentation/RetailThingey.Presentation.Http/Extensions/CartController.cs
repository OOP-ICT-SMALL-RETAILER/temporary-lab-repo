using Microsoft.AspNetCore.Mvc;
using RetailThingey.Application.Extensions.Buisnesslogic;
using RetailThingey.Application.Models.Product;

namespace RetailThingey.Presentation.Http.Extensions;

    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        public ActionResult AddToCart(ProductModel productModel, int quantity)
        {
            _cartService.AddToCart(productModel, quantity);
            return Ok();
        }

        [HttpDelete]
        public ActionResult RemoveFromCart(ProductModel productModel)
        {
            _cartService.RemoveFromCart(productModel);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateQuantity(ProductModel productModel, int newQuantity)
        {
            _cartService.UpdateQuantity(productModel, newQuantity);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<ProductModel>> GetCartItems()
        {
            var cartItems = _cartService.GetCartItems();
            return Ok(cartItems);
        }

        [HttpGet]
        public ActionResult<decimal> GetTotalPrice()
        {
            var totalPrice = _cartService.GetTotalPrice();
            return Ok(totalPrice);
        }
    }
