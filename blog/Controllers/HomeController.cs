using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using blog.Data;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using blog.ViewModels;
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
        
        // Create
        [HttpPost("/posts")]
        public IActionResult AddPost([FromBody] JsonPost post)
        {
            _repository.AddPost(post);
            return Json(post);
        }
        
        [HttpPost("/authors")]
        public IActionResult AddAuthor([FromBody] JsonAuthor author)
        {
            _repository.AddAuthor(author);
            return Json(author);
        }
        
        // Read
        [HttpGet("/posts")]
        public IActionResult GetAllPosts()
        {
            var posts = _repository.GetAllPosts();
            return Json(posts);
        }
        
        [HttpGet("/authors")]
        public IActionResult GetAllAuthors()
        {
            var authors = _repository.GetAllAuthors();
            return Json(authors);
        }
        
        [HttpGet("/posts/{id}")]
        public IActionResult GetPostById(int id)
        {
            var post = _repository.GetPostById(id);
            return Json(post);
        }
        
        [HttpGet("/authors/{id}")]
        public IActionResult GetAuthorById(int id)
        {
            var author = _repository.GetAuthorById(id);
            return Json(author);
        }
        
        [HttpGet("/posts/auth/{id}")]
        public IActionResult GetAllPostsForAuthor(int id)
        {
            var postsForAuthor = _repository.GetAllPostsForAuthor(id);
            return Json(postsForAuthor);
        }
        
        
        // Update
        [HttpPut("/posts")]
        public IActionResult UpdatePost([FromBody] Post post)
        {
            _repository.UpdatePost(post);
            return Content("success");
        }
        
        [HttpPut("/authors")]
        public IActionResult UpdateAuthor([FromBody] Author author)
        {
            _repository.UpdateAuthor(author);
            return Content("success");
        }
        
        // Delete
        [HttpDelete("/posts/{id}")]
        public IActionResult DeletePost(int id)
        {
            _repository.DeletePost(id);
            return Content("success");
        }
        
        [HttpDelete("/authors/{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            _repository.DeleteAuthor(id);
            return Content("success");
        }
        
        
        
    }
    
}