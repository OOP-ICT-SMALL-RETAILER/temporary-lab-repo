using RetailThingey.Application.Models.Product;

public interface ICartService
{
    void AddToCart(ProductModel productModel, int quantity);
    void RemoveFromCart(ProductModel productModel);
    void UpdateQuantity(ProductModel productModel, int newQuantity);
    List<ProductModel> GetCartItems();
    decimal GetTotalPrice();
}

public class CartService : ICartService
{
    private List<CartItem> _cartItems;

    public CartService()
    {
        _cartItems = new List<CartItem>();
    }

    public void AddToCart(ProductModel productModel, int quantity)
    {
        var existingItem = _cartItems.FirstOrDefault(item => item.____RULE_VIOLATION____ProductModel____RULE_VIOLATION____.Id == productModel.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            _cartItems.Add(new CartItem { ____RULE_VIOLATION____ProductModel____RULE_VIOLATION____ = productModel, Quantity = quantity });
        }
    }

    public void RemoveFromCart(ProductModel productModel)
    {
        var itemToRemove = _cartItems.FirstOrDefault(item => item.____RULE_VIOLATION____ProductModel____RULE_VIOLATION____.Id == productModel.Id);
        if (itemToRemove != null)
        {
            _cartItems.Remove(itemToRemove);
        }
    }

    public void UpdateQuantity(ProductModel productModel, int newQuantity)
    {
        var itemToUpdate = _cartItems.FirstOrDefault(item => item.____RULE_VIOLATION____ProductModel____RULE_VIOLATION____.Id == productModel.Id);
        if (itemToUpdate != null)
        {
            itemToUpdate.Quantity = newQuantity;
        }
    }

    public List<ProductModel> GetCartItems()
    {
        return _cartItems.Select(item => item.____RULE_VIOLATION____ProductModel____RULE_VIOLATION____).ToList();
    }

    public decimal GetTotalPrice()
    {
        return _cartItems.Sum(item => item.____RULE_VIOLATION____ProductModel____RULE_VIOLATION____.Price * item.Quantity);
    }
}

public class CartItem(ProductModel productModel, int quantity)
{
    public readonly ProductModel ____RULE_VIOLATION____ProductModel____RULE_VIOLATION____  = productModel;
    public int Quantity { get; set; } = quantity;
}
