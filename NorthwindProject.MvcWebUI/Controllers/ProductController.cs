using NorthwindProject.Business.Abstract;
using NorthwindProject.Business.Concrete.Managers;
using NorthwindProject.DataAccess.Concrete.EntityFramework;
using NorthwindProject.Entities.ComplexTypes;
using NorthwindProject.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindProject.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        private int _pageSize = 10;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Product
        public ActionResult Index(int? categoryId, int page = 1)
        {
            int productCount = _productService.GetProductsCountByCategory(categoryId);

            var products = _productService.GetAll(new ProductFilter {
                CategoryId = categoryId,
                Page = page,
                PageSize = _pageSize
            });

            return View(new ProductListViewModel
            {
                Products = products,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    CurrentCategory = categoryId,
                    TotalPageCount = (int)Math.Ceiling((decimal)productCount/_pageSize),
                    BaseUrl = String.Format("Product/Index/?categoryId={0}&page=", categoryId)
                }
            });
        }
    }
}