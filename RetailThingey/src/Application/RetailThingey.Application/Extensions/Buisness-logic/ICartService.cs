public interface ICartService
{
    void AddToCart(Product product, int quantity);
    void RemoveFromCart(Product product);
    void UpdateQuantity(Product product, int newQuantity);
    List<Product> GetCartItems();
    decimal GetTotalPrice();
}

public class CartService : ICartService
{
    private List<CartItem> _cartItems;

    public CartService()
    {
        _cartItems = new List<CartItem>();
    }

    public void AddToCart(Product product, int quantity)
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

    public void RemoveFromCart(Product product)
    {
        var itemToRemove = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
        if (itemToRemove != null)
        {
            _cartItems.Remove(itemToRemove);
        }
    }

    public void UpdateQuantity(Product product, int newQuantity)
    {
        var itemToUpdate = _cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
        if (itemToUpdate != null)
        {
            itemToUpdate.Quantity = newQuantity;
        }
    }

    public List<Product> GetCartItems()
    {
        return _cartItems.Select(item => item.Product).ToList();
    }

    public decimal GetTotalPrice()
    {
        return _cartItems.Sum(item => item.Product.Price * item.Quantity);
    }
}

public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}