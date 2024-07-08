using ProductsOnline.Models;

namespace ProductsOnline.Repositories
{
    public interface IDBManager
    {
        List<Product> GetProducts();

        Product GetProductById(int id);

        void Insert(Product product);

        void Update(Product product);

        void DeleteProductById(int id);
    }
}
