using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private IRobotoRepo _repo;

        public HomeController(IRobotoRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}