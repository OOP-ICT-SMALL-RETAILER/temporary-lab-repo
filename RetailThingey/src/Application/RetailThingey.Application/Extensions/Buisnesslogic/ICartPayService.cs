using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface ICartPayService
{
    void AddItemToCart(ProductModel item);
    void RemoveItemFromCart(int itemId);
    IList<ProductModel> GetCartItems();
    void ClearCart();
    decimal CalculateTotal();
}

public class CartPayService : ICartPayService
{
    private readonly List<ProductModel> _cartItems = new List<ProductModel>();

    public void AddItemToCart(ProductModel item)
    {
        _cartItems.Add(item);
    }

    public void RemoveItemFromCart(int itemId)
    {
        ProductModel itemToRemove = _cartItems.FirstOrDefault(i => i.Id == itemId)!;
        _cartItems.Remove(itemToRemove);
    }

    public IList<ProductModel> GetCartItems()
    {
        return _cartItems;
    }

    public void ClearCart()
    {
        _cartItems.Clear();
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var item in _cartItems)
        {
            total += (decimal)item.CurrentPrice;
        }
        
        return total;
    }
}