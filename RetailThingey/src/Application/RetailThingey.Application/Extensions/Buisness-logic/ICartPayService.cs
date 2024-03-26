using RetailThingey.Application.Models.Product;

public interface ICartPayService
{
    void AddItemToCart(ProductModel item);
    void RemoveItemFromCart(int itemId);
    List<ProductModel> GetCartItems();
    void ClearCart();
    decimal CalculateTotal();
}

public interface IPaymentPayService
{
    bool ProcessPayment(decimal amount);
}

public class CartPayService : ICartPayService
{
    private List<ProductModel> _cartItems = new List<ProductModel>();

    public void AddItemToCart(ProductModel item)
    {
        _cartItems.Add(item);
    }

    public void RemoveItemFromCart(int itemId)
    {
        ProductModel itemToRemove = _cartItems.FirstOrDefault(i => i.Id == itemId);
        if (itemToRemove != null)
        {
            _cartItems.Remove(itemToRemove);
        }
    }

    public List<ProductModel> GetCartItems()
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
            total += item.Price;
        }
        return total;
    }
}

public class PaymentPayService : IPaymentPayService
{
    public bool ProcessPayment(decimal amount)
    {
        if (amount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}