namespace RetailThingey.Application.Extensions.Buisnesslogic;

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
        product.CurrentPrice += (double)amount;
        _productRepository.Update(product);
    }

    public void DecreasePrice(int productId, decimal amount)
    {
        var product = _productRepository.GetProductById(productId);
        if (product.CurrentPrice - (double)amount >= 0)
        {
            product.CurrentPrice -= (double)amount;
            _productRepository.Update(product);
        }
    }
}