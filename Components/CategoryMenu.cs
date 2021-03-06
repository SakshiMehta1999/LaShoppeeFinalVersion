using LaShoppeeFinalVersion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository) {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke() {
            var categories = _categoryRepository.GetAllCategories.OrderBy(c => c.categoryName);
            return View(categories); 
        }
    }
}
