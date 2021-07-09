using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Webb.Data;
using Webb.Models;
using Webb.Views.Domain;

namespace Webb.Controllers
{
    public class DetailController : Controller
    {
        
        private readonly ProductData productData;
        DataContext dataContext;
        IMapper mapper;
        
        public DetailController(ProductData productData, DataContext dataContext, IMapper mapper)
        {
            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
       
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            var soluongcom = dataContext.Comments.Where(p => p.ProductId == id).Count();
            var dsdanhgia = dataContext.Comments.Where(p => p.ProductId == id).Include(l => l.User).ToList();          
            ViewBag.dsdanhgia = dsdanhgia;
            ViewBag.soluongcom = soluongcom;
            if (dataContext.Comments.Where(p => p.ProductId == id).Count() > 0)
            {
                double sum = dataContext.Comments.Where(p => p.ProductId == id).Average(p => p.Rating);
                ViewBag.sumrating = sum;
            }
            Product products = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            ProductModels currentProduct = new ProductModels
            {
                ProductId = products.ProductId,
                ProductName = products.ProductName,
                ProductImage = products.ProductImage,
                Color = products.Color,
                Screen = products.Screen,
                Ram = products.Ram,
                Rearcamera = products.Rearcamera,
                Frontcamera = products.Frontcamera,
                Batterycapacity = products.Batterycapacity,
                Chipset = products.Chipset,
                ProductPrice = products.ProductPrice,
                ProductQuantity = products.ProductQuantity,
                Descriptions = products.Descriptions
            };
            return View(currentProduct);
        }    
    [HttpPost]
        public IActionResult CreateCM(int productId,string content,int rating)
        {
            
            var comment = new Comment();
            comment.Content = content;
            comment.UserId=User.FindFirst(ClaimTypes.NameIdentifier).Value;             
            comment.Created = DateTime.Now;            
            comment.ProductId = productId;
            comment.Rating = rating;
            dataContext.Comments.Add(comment);
            dataContext.SaveChanges();
            return RedirectToAction("Index", new RouteValueDictionary(new { Controller = "Home", Action = "Index",id=productId }));
        }
    }
}
