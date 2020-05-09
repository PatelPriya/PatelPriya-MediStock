using BAL.Services;
using DAL.Data;
using MediStockWeb.Areas.Admin.Controllers.Base;
using MediStockWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MediStockWeb.Areas.Admin.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IWebHostEnvironment _env;
        private readonly IOrderService _orderService;
        private readonly MediStockContext _context;

        public OrderController(
        IOrderService orderService,
        IWebHostEnvironment environment, 
        MediStockContext context
            )
        {
            _env = environment;
            _orderService = orderService;
            _orderService = orderService;
            _context = context;
        }


        public IActionResult List()
        {
            //var model = new OrderModel();
            //TempData["OrderActiveMenuItem"] = "order-sidebar-id";
            //return View(model);
            var order = _context.Orders.ToList();
            return View(order);

        }

        [HttpPost]
        public IActionResult OrderList(OrderModel searchModel)
        {
            return View(searchModel);
        }
        public IActionResult Create()
        {
            var model = new OrderModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(OrderModel model)
        {
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = new OrderModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(OrderModel model)
        {
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}