using Microsoft.AspNetCore.Mvc;
using ProductsOnline.Repositories;
using ProductsOnline.Services;
using ProductsOnline.Models;

namespace ProductsOnline.Controllers
{
    public class ProductController : Controller
    {
        private IProductServices _productServices;
       
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public IActionResult Index()
        {
            /*DBManager dbmanager=new DBManager();
            List<Product> products = dbmanager.GetProducts();*/

            /*List<Product> products = _productServices.GetProducts();*/
            List<Product> products = _productServices.GetProducts();
            ViewData["catalog"] = products;
            //return Json(products);
            return View(products);
        }

        public IActionResult Products()
        { 
            return Json(_productServices.GetProducts());
        }
    }
}
