using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Webb.Data;
using Webb.Models;
using Webb.Views.Domain;

namespace Webb.Controllers
{
   
    public class HomeController : Controller
    {
        ProductData data;
        DataContext dataContext;
        IMapper mapper;


        public HomeController(ProductData productData, DataContext dataContext, IMapper mapper)
        {

            this.data = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        public IActionResult Iphone()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 1).ToList());
        }
        public IActionResult SamSung()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 2).ToList());
        }
        public IActionResult Oppo()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 3).ToList());
        }
        public IActionResult Xiaomi()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 4).ToList());
        }
        public IActionResult Search(string search)
        {
            var item = dataContext.Products.Where(p => p.ProductName.ToLower().Contains(search.ToLower())).ToList();
            return View(item);
        }
        public IActionResult Index()
        {

            List<ProductModels> products = new List<ProductModels>();
           List<Product> productss = dataContext.Products.ToList();
            foreach (var item in productss)
            {
                var map = mapper.Map<ProductModels>(item);
                products.Add(map);
            }
            return View(products);
        }
        public IActionResult About()
        {
            return View();
        }
        //public IActionResult OnGet()
        //{
        //    return ViewComponent("MessagePage", new Webb.Views.Shared.Components.MessagePage.Message
        //    {
        //        title = "Thông báo quan trọng",
        //        htmlcontent = "Đây là <strong>Nội dung HTML</strong>",
        //        secondwait = 5,
        //        urlredirect = "/"
        //    });
        //}
        public IActionResult History(int id)
        {                   
            return View(dataContext.PurcharseHis.Where(p => p.PurcharseHisId == id).Include(n => n.Order).ToList());
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
