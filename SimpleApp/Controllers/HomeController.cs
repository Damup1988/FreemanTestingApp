using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using SimpleApp.Repo;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IDataSource dataSource = new ProductDataStore();
        public ViewResult Index()
        {
            return View(dataSource.Products);
        }
    }
}