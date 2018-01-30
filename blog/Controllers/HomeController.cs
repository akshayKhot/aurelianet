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
        private BloggingContext _context { get; set;  }
        private IRepository _repository { get; set;  }

        public HomeController(BloggingContext context, IRepository repo)
        {
            _context = context;
            _repository = repo;
        }
        
        [Route("/posts")]
        public IActionResult GetAllPosts()
        {
            var posts = _repository.GetAllPosts();
            return Json(posts);
        }
        
        [Route("/posts/{id}")]
        public IActionResult GetPostById(int id)
        {
            var post = _repository.GetPostById(id);
            return Json(post);
        }
        
        [Route("/about")]
        public IActionResult GetAuthor()
        {
            var author = _repository.GetAuthorById(1);
            return Json(author);
        }
        
        [HttpPost("/posts/add")]
        public IActionResult AddPost([FromBody] Post post)
        {
            _repository.AddPost(post);
            return Json(post);
        }
        
        [HttpPost("/posts/update/{id}")]
        public IActionResult UpdatePost(int id, [FromBody] Post post)
        {
            var updatedPost = _repository.UpdatePost(id, post);
            return Json(updatedPost);
        }
        
        [HttpPost("/posts/delete/{id}")]
        public IActionResult DeletePost(int id)
        {
            _repository.DeletePost(id);
            return Content("success");
        }
    }
    
}