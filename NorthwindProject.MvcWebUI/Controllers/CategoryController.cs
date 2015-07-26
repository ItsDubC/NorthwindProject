using NorthwindProject.Business.Abstract;
using NorthwindProject.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindProject.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        public PartialViewResult List(int? categoryId)
        {
            return PartialView(new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategoryId = categoryId
            });
        }
    }
}