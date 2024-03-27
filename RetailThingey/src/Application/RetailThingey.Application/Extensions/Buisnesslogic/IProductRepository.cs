using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface IProductRepository
{
    ProductModel GetProductById(int id);
    void Update(ProductModel product);
    void Add(ProductModel productModel);
    void Delete(int productId);
}