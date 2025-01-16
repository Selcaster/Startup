﻿using Microsoft.AspNetCore.Mvc;

namespace Startup.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
