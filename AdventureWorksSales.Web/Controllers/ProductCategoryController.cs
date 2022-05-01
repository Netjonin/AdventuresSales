using AdventureWorksSales.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorksSales.Web.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryRepository _prodCateRepo;

        public ProductCategoryController(IProductCategoryRepository prodCateRepo)
        {
            _prodCateRepo = prodCateRepo;
        }

        public ActionResult Index()
        {
            var productCategories = _prodCateRepo.GetProductCategories();
            return View(productCategories);
        }
    }
}