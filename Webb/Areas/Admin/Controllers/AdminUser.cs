using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webb.Data;
using Webb.Models;

namespace Webb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class AdminUserController : Controller
    {
        private readonly DataContext dataContext;

        public AdminUserController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View(dataContext.User.ToList());
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }
            var userDb = await dataContext.User.FindAsync(id);
            if (userDb == null)
            {
                return NotFound();
            }
            return View(userDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                User userDb = dataContext.User.Where(p => p.Id == id).FirstOrDefault();
                userDb.FullName = user.FullName;
                userDb.Birthday = user.Birthday;
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }
            var userDb = await dataContext.User.FindAsync(id);
            if (userDb == null)
            {
                return NotFound();
            }
            return View(userDb);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }
            try
            {
                User userDb = dataContext.User.Where(p => p.Id == id).FirstOrDefault();
                userDb.LockoutEnd = DateTime.Now.AddYears(1000);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch (DbUpdateException)
            {
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }

        }
    }
}
