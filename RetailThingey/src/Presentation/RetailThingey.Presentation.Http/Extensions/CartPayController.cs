using Microsoft.AspNetCore.Mvc;
using RetailThingey.Application.Extensions.Buisnesslogic;
using RetailThingey.Application.Models.Product;

namespace RetailThingey.Presentation.Http.Extensions;

    [ApiController]
    [Route("[controller]")]
    public class CartPayController : ControllerBase
    {
        private readonly ICartPayService _cartPayService;
        private readonly IPaymentPayService _paymentPayService;

        public CartPayController(ICartPayService cartPayService, IPaymentPayService paymentPayService)
        {
            _cartPayService = cartPayService;
            _paymentPayService = paymentPayService;
        }

        [HttpPost("add")]
        public ActionResult AddItemToCart(ProductModel item)
        {
            _cartPayService.AddItemToCart(item);
            return Ok();
        }

        [HttpDelete("remove/{itemId}")]
        public ActionResult RemoveItemFromCart(int itemId)
        {
            _cartPayService.RemoveItemFromCart(itemId);
            return Ok();
        }

        [HttpGet("items")]
        public ActionResult<List<ProductModel>> GetCartItems()
        {
            var cartItems = _cartPayService.GetCartItems();
            return Ok(cartItems);
        }

        [HttpDelete("clear")]
        public ActionResult ClearCart()
        {
            _cartPayService.ClearCart();
            return Ok();
        }

        [HttpGet("total")]
        public ActionResult<decimal> CalculateTotal()
        {
            decimal total = _cartPayService.CalculateTotal();
            return Ok(total);
        }

        [HttpPost("payment/{amount}")]
        public ActionResult ProcessPayment(decimal amount)
        {
            bool paymentResult = _paymentPayService.ProcessPayment(amount);
            if (paymentResult)
            {
                _cartPayService.ClearCart();
                return Ok("Payment successful");
            }
            else
            {
                return BadRequest("Payment failed");
            }
        }
    }
