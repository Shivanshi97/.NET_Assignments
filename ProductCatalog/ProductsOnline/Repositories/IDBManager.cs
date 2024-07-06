using ProductsOnline.Models;

namespace ProductsOnline.Repositories
{
    public interface IDBManager
    {
        List<Product> GetProducts(GetProductsDelegate getProductsDelegate);
/*
        Product GetProductById(GetProductByIdDelegate getproductByIdDelegate, int id);

        void Insert(InsertDelegate insertDelegate, Product product);

        void Update(UpdateDelegate updateDelegate, Product product);

        void DeleteProductById(DeleteProductByIdDelegate deleteProductByIdDelegate, int id);*/
    }
}
