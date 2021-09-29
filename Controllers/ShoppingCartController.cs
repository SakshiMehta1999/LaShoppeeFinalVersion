using LaShoppeeFinalVersion.Models;
using LaShoppeeFinalVersion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBookRepository bookRepository, ShoppingCart shoppingCart) {
            _bookRepository = bookRepository;
            _shoppingCart = shoppingCart;
        }
        [Route("ShoppingCart/Index")]
        public ViewResult Index() {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        [Route("AddToShoppingCart")]
        public RedirectToActionResult AddToShoppingCart(int Bookid) {
            var selectedBooks = _bookRepository.GetAllBooks.FirstOrDefault(c => c.bookId == Bookid);
            if (selectedBooks != null) {
                _shoppingCart.AddToCart(selectedBooks, 1);
            }
            return RedirectToAction("Index");
        }
        [Route("RemoveFromShoppingCart")]
        public RedirectToActionResult RemoveFromShoppingCart(int Bookid)
        {
            var selectedBooks = _bookRepository.GetAllBooks.FirstOrDefault(c => c.bookId == Bookid);
            if (selectedBooks != null)
            {
                _shoppingCart.RemoveFromCart(selectedBooks);
            }
            return RedirectToAction("Index");
        }
        [Route("ClearCart")]
        public RedirectToActionResult ClearCart() {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
