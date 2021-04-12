using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce_WebApp.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Manage()
        {
            return View();
        }
    }
}
