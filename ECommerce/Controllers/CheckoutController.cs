﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;

namespace Ecommerce.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly IEcommerceRepo _adminRepo;
        private readonly IBasketRepo _basketRepo;
        private readonly IOrderRepo _orderRepo;
        private readonly IConfiguration Configuration;
        private readonly IEmailSender _emailSender;
        private UserManager<ApplicationUser> _userManager;
        private EcommerceDbContext _context;


        /// <summary>
        /// Bring in the information from the data layer for products, basket,
        /// checkout, emailSender
        /// </summary>
        /// <param name="adminRepo"></param>
        /// <param name="configuration"></param>
        /// <param name="basketRepo"></param>
        /// <param name="orderRepo"></param>
        /// <param name="emailSender"></param>
        /// <param name="userManager"></param>
        public CheckoutController(IEcommerceRepo adminRepo, IConfiguration configuration,
            IBasketRepo basketRepo, IOrderRepo orderRepo,
            IEmailSender emailSender, UserManager<ApplicationUser> userManager, EcommerceDbContext context)
        {
            _adminRepo = adminRepo;
            _basketRepo = basketRepo;
            _orderRepo = orderRepo;
            _userManager = userManager;
            _emailSender = emailSender;
            Configuration = configuration;
            _context = context;
        }

        /// <summary>
        /// Main view of the index page and a user can apply a discount
        /// This is where they can start to put in their shipping info
        /// </summary>
        /// <param name="discountCoupon"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(string discountCoupon)
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            Basket datBasket = _basketRepo.GetUserBasketByEmail(user.Email).Result;

            if (datBasket == null || datBasket.BasketItems.Count == 0)
            {
                return RedirectToAction("MyBasket", "Shop");
            }

            CheckoutViewModel datCheckoutVM = new CheckoutViewModel
            {
                Basket = datBasket,
            };

            if (!String.IsNullOrEmpty(discountCoupon))
            {
                string upperCaseCoupon = discountCoupon.ToUpper();

                if (upperCaseCoupon == "KARTEKLIENTI")
                {
                    datCheckoutVM.DiscountPercent = 20;
                }

                if (upperCaseCoupon == "KARTESTUDENTI")
                {
                    datCheckoutVM.DiscountPercent = 10;
                }

                datCheckoutVM.DiscountName = upperCaseCoupon;
            }

            return View(datCheckoutVM);
        }

        /// <summary>
        /// Adds an address to a user
        /// </summary>
        /// <param name="cvm"></param>
        /// <returns>the view of the shipping page with the CheckoutViewModel object </returns>
        [HttpPost]
        public async Task<IActionResult> AddAddress(CheckoutViewModel cvm)
        {
            if (cvm == null || cvm.Address == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            Basket datBasket = _basketRepo.GetUserBasketByEmail(user.Email).Result;

            cvm.Basket = datBasket;
            return View("Shipping", cvm);
        }

        /// <summary>
        /// Finds the user by their email
        /// Finds the basket associated with the user
        /// </summary>
        /// <param name="cvm"></param>
        /// <returns></returns>
        public async Task<IActionResult> Shipping(CheckoutViewModel cvm)
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            Basket datBasket = _basketRepo.GetUserBasketByEmail(user.Email).Result;

            cvm.Basket = datBasket;

            if (ModelState.IsValid)
            {
                return View(cvm);
            }

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Create a new order from the contexts of the cvm object
        /// </summary>
        /// <param name="cvm"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Confirm(CheckoutViewModel cvm)
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            Basket datBasket = _basketRepo.GetUserBasketByEmail(user.Email).Result;

            using (var transaction = _context.Database.BeginTransaction()) {

                try {
                    

                    if (datBasket.BasketItems.Count == 0)
                        return RedirectToAction(nameof(Index));

                    cvm.Basket = datBasket;

                    if (!ModelState.IsValid)
                        return RedirectToAction(nameof(Shipping));

                    // add address to database
                    await _orderRepo.CreateAddress(cvm.Address);

                    // create an new order object and load the order items onto it
                    Order datOrder = new Order {
                        UserID = user.Id,
                        AddressID = cvm.Address.ID,
                        Address = cvm.Address,
                        OrderDate = DateTime.Now.ToString("MMM d, yyyy (ddd) @ HH:mm tt"),
                        Shipping = cvm.Shipping,
                        DiscountName = cvm.DiscountName,
                        DiscountPercent = cvm.DiscountPercent,
                        DiscountAmt = cvm.DiscountAmt,
                        TotalItemQty = cvm.TotalItemQty,
                        Subtotal = cvm.Subtotal,
                        Total = cvm.Total,
                    };

                    // add order to the database table
                    // I'm doing this first in hopes that the order generates an ID that
                    // I can add to the order items. Here's hoping...
                    await _orderRepo.AddOrderAsync(datOrder);

                    // turn basket items into order items
                    List<OrderItem> demOrderItems = new List<OrderItem>();
                    foreach (var item in datBasket.BasketItems) {
                        OrderItem tempOrderItem = new OrderItem {
                            ProductID = item.ProductID,
                            OrderID = datOrder.ID,
                            UserID = user.Id,
                            ProductName = item.ProductName,
                            Quantity = item.Quantity,
                            ImgUrl = item.ImgUrl,
                            UnitPrice = item.UnitPrice
                        };

                        // add order item to the database table
                        await _orderRepo.AddOrderItemToOrderAsync(tempOrderItem);
                        demOrderItems.Add(tempOrderItem);
                    }

                    // attach orderitems to order
                    datOrder.OrderItems = demOrderItems;

                    //sends a receipt of the order information
                    string htmlMessage = "Thank you for shopping with us!  You ordered: </br>";
                    foreach (var item in datOrder.OrderItems) {
                        htmlMessage += $"Item: {item.ProductName}, Quantity: {item.Quantity}</br>";
                    };

                    CardInfo cardInfo = new CardInfo {
                        CardNumber = cvm.CardInfo.CardNumber,
                        CardCode = cvm.CardInfo.CardCode,
                        ExpirationDate = cvm.CardInfo.ExpirationDate
                    };

                    //CHARGE CARD
                    Payment payment = new Payment(Configuration);
                    payment.RunPayment(cvm.Total, datOrder, user, cardInfo);

                    await _emailSender.SendEmailAsync(user.Email, "Order Information",
                                htmlMessage);
                    // empty out basket
                    await _basketRepo.ClearOutBasket(cvm.Basket.BasketItems);

                    transaction.Commit();

                    return View("Confirmed", datOrder);
                } catch (Exception e) {
                    transaction.Rollback();
                    ModelState.AddModelError(string.Empty, e.Message);
                    return View("Index", cvm);
                } 
            }
        }

        /// <summary>
        /// Pass the order object back to the confirm view
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public IActionResult Confirmed(Order order)
        {
            return View(order);
        }
    }
}