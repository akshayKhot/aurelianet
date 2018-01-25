using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using blog.Data;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using Microsoft.EntityFrameworkCore;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private BloggingContext _context { get; set; }

        public HomeController(BloggingContext context)
        {
            _context = context;
        }
        public IActionResult Home()
        {
            var posts = _context.Posts.ToList();
            ViewData["Posts"] = posts;
            return View();
        }
    }
}