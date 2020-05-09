using DAL.Data;
using MediStockWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MediStockWeb.Views.ViewComponents
{
    public class SliderMenuViewComponent : ViewComponent
    {

        #region Fields
        private readonly MediStockContext _context;
        //const int pageSize = 3;

        #endregion

        #region Ctor
        public SliderMenuViewComponent(MediStockContext context)
        {
            _context = context;
        }
        #endregion

        public IViewComponentResult Invoke()
        {
            var medicine = _context.Medicines.ToList();
            var homelist = new List<HomeModel>();
            foreach(var item in medicine)
            {
                var model = new HomeModel
                { 
                    ImageUrl= "/images/" + item.PictureStr,
                    Name = item.Name,
                    Price = item.Price

                };
                homelist.Add(model);
            }
            return View(homelist);
        }
    }
}
