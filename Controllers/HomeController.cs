using LaShoppeeFinalVersion.Models;
using LaShoppeeFinalVersion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public HomeController(IBookRepository bookRepository) {
            _bookRepository = bookRepository;
        }
        [Route("Home")]
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                bookOnSale = _bookRepository.GetBooksOnSale
            };
            return View(homeViewModel);
        }
        [Route("Home/Admin")]
        public IActionResult Admin()
        {
            var homeViewModel = new HomeViewModel()
            {
                bookOnSale = _bookRepository.GetBooksOnSale
            };
            return View(homeViewModel);
        }
    }
}
