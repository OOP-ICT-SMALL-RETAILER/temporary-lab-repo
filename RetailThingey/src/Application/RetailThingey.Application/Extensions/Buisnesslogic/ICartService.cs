using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface ICartService
{
    void AddToCart(ProductModel productModel, int quantity);
    void RemoveFromCart(ProductModel productModel);
    void UpdateQuantity(ProductModel productModel, int newQuantity);
    IList<ProductModel?> GetCartItems();
    decimal GetTotalPrice();
}

public class CartService : ICartService
{
    private readonly List<CartItem> _cartItems;

    private class CartItem
    {
        public ProductModel? ProductModel { get; set; }
        public int Quantity { get; set; }
    }

    public CartService()
    {
        _cartItems = new List<CartItem>();
    }

    public void AddToCart(ProductModel productModel, int quantity)
    {
        var existingItem = _cartItems.FirstOrDefault(item => item.ProductModel!.Id == productModel.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            _cartItems.Add(new CartItem { ProductModel = productModel, Quantity = quantity });
        }
    }

    public void RemoveFromCart(ProductModel productModel)
    {
        var itemToRemove = _cartItems.FirstOrDefault(item => item.ProductModel!.Id == productModel.Id);
        if (itemToRemove != null)
        {
            _cartItems.Remove(itemToRemove);
        }
    }

    public void UpdateQuantity(ProductModel productModel, int newQuantity)
    {
        var itemToUpdate = _cartItems.FirstOrDefault(item => item.ProductModel!.Id == productModel.Id);
        if (itemToUpdate != null)
        {
            itemToUpdate.Quantity = newQuantity;
        }
    }

    public IList<ProductModel?> GetCartItems()
    {
        return _cartItems.Select(item => item.ProductModel).ToList();
    }

    public decimal GetTotalPrice()
    {
        return (decimal)_cartItems.Sum(item =>
        {
            if (item.ProductModel != null)
                return item.ProductModel.CurrentPrice * item.Quantity;
            return 0;
        });
    }
}
