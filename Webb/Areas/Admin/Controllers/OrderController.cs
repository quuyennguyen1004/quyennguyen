using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webb.Data;
using Webb.Views.Domain;

namespace Webb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class OrderController : Controller
    {
        private readonly DataContext dataContext;
        public OrderController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await dataContext.Orders.ToListAsync());
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var orderpro = await dataContext.Orders.FindAsync(id);
            if (orderpro == null)
            {
                return NotFound();
            }
            return View(orderpro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,OrderDate,Name,DiaChi,Phone,isConfirm")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                try
                {
                    dataContext.Update(order);
                    await dataContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExist(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var orderpro = await dataContext.Orders.FirstOrDefaultAsync(p => p.OrderId == id);
            if (orderpro == null)
            {
                return NotFound();
            }
            return View(orderpro);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var orderpro = await dataContext.Orders.FindAsync(id);
            dataContext.Orders.Remove(orderpro);
            await dataContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool OrderExist(int id)
        {
            return dataContext.Orders.Any(p => p.OrderId == id);
        }
    }
}
