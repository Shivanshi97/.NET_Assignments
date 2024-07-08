using ProductsOnline.Models;
using ProductsOnline.Repositories;

namespace ProductsOnline.Services
{
    public class ProductServices : IProductServices
    {
        public IDBManager _dbmanager;

        public ProductServices(IDBManager dbmanager)
        {
            _dbmanager = dbmanager;
        }

       
/*
        public Product GetProductById(int id)
        {
            //throw new NotImplementedException();
        }
*/
        public List<Product> GetProducts()
        {
           return _dbmanager.GetProducts();
        }
/*
        public void Insert(Product product)
        {
            
           // throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            
            //throw new NotImplementedException();
        }

        public void DeleteProductById(int id)
        {
            
            //throw new NotImplementedException();
        }

*/


    }
}
