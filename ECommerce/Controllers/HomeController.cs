using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private IEcommerceRepo _repo;

        public HomeController(IEcommerceRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}