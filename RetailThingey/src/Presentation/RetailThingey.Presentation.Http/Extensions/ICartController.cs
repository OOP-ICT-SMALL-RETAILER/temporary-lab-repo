using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ICartController.Controllers
{
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
        public ActionResult AddToCart(Product product, int quantity)
        {
            _cartService.AddToCart(product, quantity);
            return Ok();
        }

        [HttpDelete]
        public ActionResult RemoveFromCart(Product product)
        {
            _cartService.RemoveFromCart(product);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateQuantity(Product product, int newQuantity)
        {
            _cartService.UpdateQuantity(product, newQuantity);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<Product>> GetCartItems()
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
}