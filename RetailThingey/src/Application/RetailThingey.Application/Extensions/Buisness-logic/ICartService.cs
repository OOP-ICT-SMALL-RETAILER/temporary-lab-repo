using RetailThingey.Application.Models.Product;

public interface ICartService
{
    void AddToCart(_Product product, int quantity);
    void RemoveFromCart(_Product product);
    void UpdateQuantity(_Product product, int newQuantity);
    List<_Product> GetCartItems();
    decimal GetTotalPrice();
}

public class CartService : ICartService
{
    private List<CartItem> _cartItems;

    public CartService()
    {
        _cartItems = new List<CartItem>();
    }

    public void AddToCart(_Product product, int quantity)
    {
        var existingItem = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            _cartItems.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }

    public void RemoveFromCart(_Product product)
    {
        var itemToRemove = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
        if (itemToRemove != null)
        {
            _cartItems.Remove(itemToRemove);
        }
    }

    public void UpdateQuantity(_Product product, int newQuantity)
    {
        var itemToUpdate = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
        if (itemToUpdate != null)
        {
            itemToUpdate.Quantity = newQuantity;
        }
    }

    public List<_Product> GetCartItems()
    {
        return _cartItems.Select(item => item.Product).ToList();
    }

    public decimal GetTotalPrice()
    {
        return _cartItems.Sum(item => item.Product.Price * item.Quantity);
    }
}

public class CartItem(_Product product, int quantity)
{
    public readonly _Product Product  = product;
    public int Quantity { get; set; } = quantity;
}
