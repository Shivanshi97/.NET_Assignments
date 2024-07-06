using ProductsOnline.Models;

namespace ProductsOnline.Repositories
{
    //delegates to connect DBManager with ProductService
    public delegate List<Product> GetProductsDelegate();

    public delegate Product GetProductByIdDelegate(int id);

    public delegate void InsertDelegate(Product product);

    public delegate void UpdateDelegate(Product product);

    public delegate void DeleteProductByIdDelegate(int id);



    public class DBManager : IDBManager
    {
        public List<Product> GetProducts(GetProductsDelegate getProductsDelegate)
        {
            return getProductsDelegate();
            //throw new NotImplementedException();
        }
/*
        public Product GetProductById(GetProductByIdDelegate getproductByIdDelegate ,int id)
        {
            return getproductByIdDelegate(id);
            //throw new NotImplementedException();
        }

        public void Insert(InsertDelegate insertDelegate, Product product)
        {
            insertDelegate(product);
            //throw new NotImplementedException();
        }

        public void Update(UpdateDelegate updateDelegate ,Product product)
        {
            updateDelegate(product);
            //throw new NotImplementedException();
        }

        public void DeleteProductById(DeleteProductByIdDelegate deleteProductByIdDelegate ,int id)
        {   
            deleteProductByIdDelegate(id);
            //throw new NotImplementedException();
        }*/
    }
}
