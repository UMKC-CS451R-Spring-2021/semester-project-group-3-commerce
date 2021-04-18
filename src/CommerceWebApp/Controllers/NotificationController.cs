using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Commerce_WebApp.Models;
using Commerce_WebApp.Data;

namespace Commerce_WebApp.Controllers
{
    public class NotificationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotificationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Manage()
        {
            return View(await _context.Notification_Rule.FromSqlInterpolated($"ReturnNotificationRules {User.Identity.Name}").ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Conditions = new List<string>() { "Below", "Above" };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Customer_Id,Type,Condition,Value")] Notification_Rule notification_Rule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notification_Rule);
                await _context.SaveChangesAsync();
                return RedirectToAction("Manage");
            }

            ViewBag.Conditions = new List<string>() { "Below", "Above" };
            return View(notification_Rule);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notification_Rule = await _context.Notification_Rule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notification_Rule == null)
            {
                return NotFound();
            }

            return View(notification_Rule);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notification_Rule = await _context.Notification_Rule.FindAsync(id);
            _context.Notification_Rule.Remove(notification_Rule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
