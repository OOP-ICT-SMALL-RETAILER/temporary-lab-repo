using RetailThingey.Application.Models.Product;

public interface ICartPayService
{
    void AddItemToCart(_Product item);
    void RemoveItemFromCart(int itemId);
    List<_Product> GetCartItems();
    void ClearCart();
    decimal CalculateTotal();
}

public interface IPaymentPayService
{
    bool ProcessPayment(decimal amount);
}

public class CartPayService : ICartPayService
{
    private List<_Product> _cartItems = new List<_Product>();

    public void AddItemToCart(_Product item)
    {
        _cartItems.Add(item);
    }

    public void RemoveItemFromCart(int itemId)
    {
        _Product itemToRemove = _cartItems.FirstOrDefault(i => i.Id == itemId);
        if (itemToRemove != null)
        {
            _cartItems.Remove(itemToRemove);
        }
    }

    public List<_Product> GetCartItems()
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