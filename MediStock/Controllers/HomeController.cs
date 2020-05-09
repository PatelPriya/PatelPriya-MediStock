using BAL.Services;
using DAL.Data;
using DAL.Domains;
using MediStockWeb.Controllers.Base;
using MediStockWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MediStockWeb.Controllers
{
    public class HomeController : BaseController
    {
        #region Fields
        private readonly ICategoryService _categoryService;
        private readonly MediStockContext _context;
        //const int pageSize = 3;

        #endregion

        #region Ctor
        public HomeController(ICategoryService categoryService, MediStockContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        #endregion

        // Sample add comment to show the github pull
        [HttpGet]
        public IActionResult Index()
        {
            //var medicine = _context.Medicines.FirstOrDefault();
            //var model = new HomeModel();
            //model.ImageUrl = "~/images/" + medicine.PictureStr;
            //return View(model);
            //return ViewComponent("SliderMenu");
            return View();
        }

        [HttpPost]
        public IActionResult Index(Category category)
        {
            return ViewComponent("CategoryMenu");
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}