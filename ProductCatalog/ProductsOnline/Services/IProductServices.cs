using ProductsOnline.Models;

namespace ProductsOnline.Services
{
    public interface IProductServices
    {
        List<Product> GetProducts();
        /*
                Product GetProductById(int id);

                void Insert(Product product);

                void Update(Product product);

                void DeleteProductById(int id);*/
    }

}
