using ProductsOnline.Models;
using ProductsOnline.Repositories;

namespace ProductsOnline.Services
{
    public class ProductServices : IProductServices
    {
        public DBManager dbmanager;

        public ProductServices(DBManager dbmanager)
        {
            this.dbmanager = dbmanager;
        }

       
/*
        public Product GetProductById(int id)
        {
            //throw new NotImplementedException();
        }
*/
        public List<Product> GetProducts()
        {
            dbmanager.GetProducts();
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
