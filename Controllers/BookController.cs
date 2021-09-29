using LaShoppeeFinalVersion.Models;
//using LaShoppeeFinalVersion.Models.ViewModels;
using LaShoppeeFinalVersion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Controllers
{
    
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        public BookController(IBookRepository bookRepository,ICategoryRepository categoryRepository ) {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }
        [Route("Book/List")]
        public ViewResult List(string category) {
            IEnumerable<Books> Bookies;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                Bookies = _bookRepository.GetAllBooks.OrderBy(c => c.bookId);
                currentCategory = "All Books";
            }
            else {
                Bookies = _bookRepository.GetAllBooks.Where(c => c.Category.categoryName == category);
                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.categoryName == category)?.categoryName;
            }
            return View(new BookListViewModel
            {
                bookies = Bookies,
                CurrentCategory = currentCategory

            }) ;
        }
       
        [Route("Book/Details")]
        public IActionResult Details(int id) {
            var book = _bookRepository.GetBookBYId(id);
            if (book == null)
                return NotFound();
            return View(book);
        }
    }
}
