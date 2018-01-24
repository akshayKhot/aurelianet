using System.Linq;
using blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class AboutController : Controller
    {
        private BloggingContext _context;
        public AboutController(BloggingContext context)
        {
            _context = context;
        }
        
        public IActionResult Home()
        {
            var author = _context.Authors.Single(auth => auth.ID == 1);
            return View("About", author);
        }
        
    }
}