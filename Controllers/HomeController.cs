using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using th01.Models;
using th01.Models.Interfaces;

namespace th01.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.GetTrendingProducts());
        }

    }
}
