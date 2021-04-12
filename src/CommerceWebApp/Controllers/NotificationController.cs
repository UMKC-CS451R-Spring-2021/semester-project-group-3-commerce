using Microsoft.AspNetCore.Mvc;
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
            return View(await _context.Notification_Rule.ToListAsync());
        }
    }
}
