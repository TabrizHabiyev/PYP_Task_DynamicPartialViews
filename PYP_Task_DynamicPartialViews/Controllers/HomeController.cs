using Microsoft.AspNetCore.Mvc;
using PYP_Task_DynamicPartialViews.Models;
using System.Diagnostics;

namespace PYP_Task_DynamicPartialViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = Guid.NewGuid() , Name = "Product1" , Price = 250 },
                new Product { Id = Guid.NewGuid() , Name = "Product2" , Price = 403 },
                new Product { Id = Guid.NewGuid() , Name = "Product3" , Price = 120 }
            };

            return View(products);
        }
    }
}