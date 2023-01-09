using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstoreWebApp.Models;
using BOL;
using BLL;
namespace EstoreWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatlogManager manager=new CatlogManager();
        List<Product> allProducts=manager.GetAllProducts();
        this.ViewData["products"]=allProducts;
        return View();
    }

    public IActionResult Details( int id)
    {
         CatlogManager manager=new CatlogManager();
         Product product=manager.GetProduct(id);
         this.ViewData["product"]=product;
        return View();
    }

      public IActionResult Insert()
    {
        return View();
    }

        public IActionResult Delete( int id)
    {
        return RedirectToAction("Index");
        
    }
   
}
