﻿using BookLibraryApp5._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookLibraryApp5._0.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index() => View();
          
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
    }
}
