public interface IProductPriceService
{
    void IncreasePrice(int productId, decimal amount);
    void DecreasePrice(int productId, decimal amount);
}

public class ProductPriceService : IProductPriceService
{
    private readonly IProductRepository _productRepository;

    public ProductPriceService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void IncreasePrice(int productId, decimal amount)
    {
        var product = _productRepository.GetProductById(productId);
        product.Price += amount;
        _productRepository.Update(product);
    }

    public void DecreasePrice(int productId, decimal amount)
    {
        var product = _productRepository.GetProductById(productId);
        if (product.Price - amount >= 0)
        {
            product.Price -= amount;
            _productRepository.Update(product);
        }
    }
}