using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Contracts.ProductInterface;

public interface IProductBuilder
{
    IProductBuilder SetId(int id);
    IProductBuilder SetName(string name);
    IProductBuilder SetCurrentPrice(double currentPrice);
    IProductBuilder SetDescription(string description);
    IProductBuilder SetRating(double rating);
    IProductBuilder SetIsListed(bool isListed);
    Product Build();
}