using Microsoft.AspNetCore.Mvc;
using ProductsOnline.Repositories;
using ProductsOnline.Services;
using ProductsOnline.Models;

namespace ProductsOnline.Controllers
{
    public class ProductController : Controller
    {
        private ProductServices _productServices;
        private DBManager _dbManager;

        public ProductController(ProductServices productServices, DBManager dbManager)
        {
            _productServices = productServices;
            _dbManager = dbManager;
        }
        public IActionResult Index()
        {   
            DBManager dbmanager=new DBManager();
            List<Product> products = dbmanager.GetProducts(()=>_productServices.GetProducts());
            //invokes the GetProducts() method of ProductServices via DBManager,
            //assuming ProductServices implements GetProductsDelegate.

            return View(products);
        }

        public IActionResult Products()
        { 
            return Json(_productServices.GetProducts());
        }
    }
}
