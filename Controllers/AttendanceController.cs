﻿using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Manager.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
