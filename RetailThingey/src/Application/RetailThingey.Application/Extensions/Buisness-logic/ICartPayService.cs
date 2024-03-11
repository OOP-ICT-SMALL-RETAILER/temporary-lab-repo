public interface ICartPayService
{
    void AddItemToCart(Item item);
    void RemoveItemFromCart(int itemId);
    List<Item> GetCartItems();
    void ClearCart();
    decimal CalculateTotal();
}

public interface IPaymentPayService
{
    bool ProcessPayment(decimal amount);
}

public class CartPayService : ICartPayService
{
    private List<Item> _cartItems = new List<Item>();

    public void AddItemToCart(Item item)
    {
        _cartItems.Add(item);
    }

    public void RemoveItemFromCart(int itemId)
    {
        Item itemToRemove = _cartItems.FirstOrDefault(i => i.Id == itemId);
        if (itemToRemove != null)
        {
            _cartItems.Remove(itemToRemove);
        }
    }

    public List<Item> GetCartItems()
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