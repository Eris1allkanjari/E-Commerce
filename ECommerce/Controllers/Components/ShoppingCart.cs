using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ecommerce.Models;
using System.Threading.Tasks;

namespace Ecommerce.Controllers.Components
{
    public class ShoppingCart : ViewComponent
    {
        private readonly IEcommerceRepo _adminRepo;
        private readonly IBasketRepo _basketRepo;
        private readonly IConfiguration Configuration;
        private UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// bring in the information from the data layer for the inventory and basket information
        /// </summary>
        /// <param name="adminRepo"></param>
        /// <param name="configuration"></param>
        /// <param name="basketRepo"></param>
        /// <param name="userManager"></param>
        public ShoppingCart(IEcommerceRepo adminRepo, IConfiguration configuration, IBasketRepo basketRepo,
            UserManager<ApplicationUser> userManager)
        {
            _adminRepo = adminRepo;
            _basketRepo = basketRepo;
            _userManager = userManager;
            Configuration = configuration;
        }

        /// <summary>
        /// find the basket connected with a user, which is by their email
        /// if the basket is empty, give them a new one
        /// </summary>
        /// <returns>the datBasket to the view</returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Basket datBasket;
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            datBasket = _basketRepo.GetUserBasketByEmail(user.Email).Result;
            if (datBasket == null)
            {
                datBasket = new Basket();
            }
            return View(datBasket);
        }
    }
}