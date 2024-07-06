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
            return dbmanager.GetProductById(GetDBById, id);
            //throw new NotImplementedException();
        }
*/
        public List<Product> GetProducts()
        {
            using (var context = new EStoreCollectionContext())
            {
                var products = from prod in context.Products
                               select prod;
                return products.ToList<Product>();
            }
            //throw new NotImplementedException();
        }
/*
        public void Insert(Product product)
        {
            dbmanager.Insert(InsertDB, product);
           // throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            dbmanager.Update(UpdateDB, product);
            //throw new NotImplementedException();
        }

        public void DeleteProductById(int id)
        {
            dbmanager.DeleteProductById(DeleteDB, id);
            //throw new NotImplementedException();
        }

        private void InsertDB(Product product)
        {

        }
        
        private void UpdateDB(Product product)
        {

        }

        private void DeleteDB(int id)
        {
        
        }

        private Product GetDBById(int id)
        {
            return;
        }
*/
        private List<Product> GetDB()
        {   

            //throw new NotImplementedException();
        }



    }
}
