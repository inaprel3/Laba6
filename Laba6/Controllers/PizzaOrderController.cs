// Controllers/PizzaOrderController.cs
using Microsoft.AspNetCore.Mvc;
using Laba6.Models;
using System;

namespace Laba6.Controllers
{
    public class PizzaOrderController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmOrder(User user)
        {
            if (user.Age > 16)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult ProcessOrder(Product[] products)
        {
            if (products == null || products.Length == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
                }

                return View(products);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}