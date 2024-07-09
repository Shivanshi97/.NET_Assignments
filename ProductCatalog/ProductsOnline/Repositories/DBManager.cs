using ProductsOnline.Models;
 

namespace ProductsOnline.Repositories
{
       public class DBManager : IDBManager
    {
        public List<Product> GetAllProducts()
        {
            using (var context = new EStoreCollectionContext())
            {
                var products = from prod in context.Products
                               select prod;

                return products.ToList<Product>();
            }
            //throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductById(int id)
        {   
            throw new NotImplementedException();
        }
    }
}
