using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Services.Abstract;
using Blog.Shared.Utilities.Results.ComplexTypes;

namespace Blog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAll();
            if (result.ResultStatus==ResultStatus.Succes)
            {
                return View(result.Data);
            }

            return View();
        }
    }
}
