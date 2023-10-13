using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using PaginationExample.Models;
using System.Diagnostics;

namespace PaginationExample.Controllers
{
    //Sayfalama için PagedList.Core.Mvc paketini yükledim.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page=1, int pagesize = 3)
        {

            PagedList<Product> model = new PagedList<Product>(SeedProduct.GetAll().AsQueryable(), page, pagesize);

            //2 şekilde de kullanılır. 
            //var model = SeedProduct.GetAll().AsQueryable().ToPagedList(page, 3);
            return View("Index",model);
        }

        public IActionResult Privacy()
        {
            return View();
        }        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}