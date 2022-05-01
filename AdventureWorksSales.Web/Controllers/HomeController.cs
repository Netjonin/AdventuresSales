using AdventureWorksSales.Web.Models.ViewModels;
using AdventureWorksSales.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorksSales.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _prodRepo;
        private readonly ISalesOrderRepository _salesOrderRepo;

        public HomeController(IProductRepository prodRepo, ISalesOrderRepository salesOrderRepo)
        {
            _prodRepo = prodRepo;
            _salesOrderRepo = salesOrderRepo;
        }

        public ActionResult Index()
        {
            var salesOrders = _salesOrderRepo.GetSalesOrders();
            var frontBrakesId = _prodRepo.GetProductByName("Front Brakes").ProductId;

            var homeData = new HomeViewModel
            {
                TotalOrders = salesOrders.Count(),
                HighestLineTotal = Math.Round(salesOrders.Select(x => x.LineTotal).Max(), 3),
                FrontBrakesSalesTotal = salesOrders.Where(x => x.ProductId == frontBrakesId).Count()
            };

            ViewBag.data = homeData;
            return View();
        }

    }
}