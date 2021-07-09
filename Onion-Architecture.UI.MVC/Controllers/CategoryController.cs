using Microsoft.AspNetCore.Mvc;
using Onion_Architecture.Core.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion_Architecture.UI.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService categoryService;
        public CategoryController(CategoryService categoryservice)
        {
            this.categoryService = categoryservice;
        }
        public IActionResult Add()
        {
            var categoryName = $"Category {DateTime.Now.Ticks}";

            categoryService.AddCategory(categoryName);

            return View();
        }
    }
}
