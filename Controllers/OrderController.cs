﻿using LaShoppeeFinalVersion.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Controllers
{
    [Authorize]
    public class OrderController :Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        [Route("Order/CheckOut")]
        public IActionResult CheckOut() {
            return View();
        }
        [Route("Order/CheckOut")]
        [HttpPost]
        
        public IActionResult CheckOut(Order order) {

            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            if (_shoppingCart.ShoppingCartItems.Count == 0) {
                ModelState.AddModelError("", "Your Cart is empty");
            }
            if (ModelState.IsValid) {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }
        [Route("Order/CheckoutComplete")]
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thankyou For choosing us. Enjoy your order";
            return View();
        }
    }
}
