public interface IProductService
{
    void AddProduct(Product product);
    void DeleteProduct(int productId);
}

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void AddProduct(Product product)
    {
        _productRepository.Add(product);
    }

    public void DeleteProduct(int productId)
    {
        _productRepository.Delete(productId);
    }
}