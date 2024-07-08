using Microsoft.AspNetCore.Mvc;
using ProductsOnline.Repositories;
using ProductsOnline.Services;
using ProductsOnline.Models;

namespace ProductsOnline.Controllers
{
    public class ProductController : Controller
    {
        private IProductServices _productServices;
        private IDBManager _dbManager;

        public ProductController(ProductServices productServices, DBManager dbManager)
        {
            _productServices = productServices;
            _dbManager = dbManager;
        }
        public IActionResult Index()
        {   
            DBManager dbmanager=new DBManager();
            List<Product> products = dbmanager.GetProducts();
           
            return View(products);
        }

        public IActionResult Products()
        { 
            return Json(_productServices.GetProducts());
        }
    }
}
