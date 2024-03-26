using RetailThingey.Application.Models.Product;

public interface IProductService
{
    void AddProduct(ProductModel productModel);
    void DeleteProduct(int productId);
}

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void AddProduct(ProductModel productModel)
    {
        _productRepository.Add(productModel);
    }

    public void DeleteProduct(int productId)
    {
        _productRepository.Delete(productId);
    }
}