using AutoMapper;
using BraintreeHttp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PayPal.Core;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Webb.Data;
using Webb.Helper;
using Webb.Models;
using Webb.PaypalHelper;
using Webb.Views.Domain;


namespace Webb.Controllers
{

    public class CartController : Controller
    {
        private readonly DataContext dataContext;     

        public IConfiguration configuration { get; }

        [BindProperty]
        public ProductToCart ProductToCart { get; set; }
        public CartController(DataContext dataContext,IConfiguration _configuration)
        {
            this.dataContext = dataContext;
            configuration = _configuration;
            ProductToCart = new ProductToCart()
            {
                products = new List<Views.Domain.Product>()
            };
        }
        public async Task<IActionResult> Index()
        {
           
            List<int> listShop = HttpContext.Session.Get<List<int>>("ShoppingCart");
            if (listShop.Count > 0)
            {
                foreach (int cartitem in listShop)
                {
                    Product product = dataContext.Products.Include(p => p.Category).Where(p => p.ProductId == cartitem).FirstOrDefault();
                    ProductToCart.products.Add(product);
                }
            }

            return View(ProductToCart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> IndexPost()
        {
            if (ModelState.IsValid)
            {
                List<int> listCartItem = HttpContext.Session.Get<List<int>>("ShoppingCart");
                ProductToCart.order.OrderDate = ProductToCart.order.OrderDate;
                Views.Domain.Order order = ProductToCart.order;
                dataContext.Orders.Add(order);
                await dataContext.SaveChangesAsync();

                int orderId = order.OrderId;


                foreach (int productId in listCartItem)
                {
                    try
                    {

                        //var total = SSShoppingCartVM.Products.Where(a=>a.Id==productId).Sum(c => c.Price);
                        OrderDetail detailsOrder = new OrderDetail()
                        {

                            OrderId = orderId,
                            ProductId = productId,
                            //Total = SSShoppingCartVM.Products.Sum(a => a.Price)

                        };
                        dataContext.OrderDetails.Add(detailsOrder);
                    }

                    catch (Exception ex)
                    {

                    }

                }
                await dataContext.SaveChangesAsync();
                listCartItem = new List<int>();
                HttpContext.Session.Set("ShoppingCart", listCartItem);
                return RedirectToAction("OrderConfirm", "Cart", new { Id = orderId });
            }
            return RedirectToAction("Index");
        }
        public IActionResult Buy(int id)
        {
            List<int> listShop = HttpContext.Session.Get<List<int>>("ShoppingCart");
            if (listShop == null)
            {
                listShop = new List<int>();
            }
            listShop.Add(id);
            HttpContext.Session.Set("ShoppingCart", listShop);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Delete(int id)
        {
            List<int> listShop = HttpContext.Session.Get<List<int>>("ShoppingCart");
            if (listShop.Count > 0)
            {
                if (listShop.Contains(id))
                {
                    listShop.Remove(id);
                }
            }
            HttpContext.Session.Set("ShoppingCart", listShop);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> OrderConfirm(int id)
        {
            ProductToCart.order = await dataContext.Orders.Where(p => p.OrderId == id).FirstOrDefaultAsync();
            List<OrderDetail> orderList = dataContext.OrderDetails.Where(p => p.OrderId == id).ToList();
            foreach (OrderDetail orderDetail in orderList)
            {
                ProductToCart.products.Add(await dataContext.Products.Include(p => p.Category).Where(p => p.ProductId == orderDetail.ProductId).FirstOrDefaultAsync());
            }
            return View(ProductToCart);
        }
        [HttpPost]       
        public async Task<IActionResult> PaypalCheckout(double total)
        {
            var payPalAPI = new PayPalAPI(configuration);
             string url= await payPalAPI.getRedirectURLToPayPal(total);
            return Redirect(url);
        }
        public IActionResult CheckoutFail()
        {
            //Tạo đơn hàng trong database với trạng thái thanh toán là "Chưa thanh toán"
            //Xóa session
            return View();
        }
        public IActionResult CheckoutSuccess()
        {
            //Tạo đơn hàng trong database với trạng thái thanh toán là "Paypal" và thành công
            //Xóa session
            return View();
        }
    }
    }

