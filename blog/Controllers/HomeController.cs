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
        
        [Route("/posts")]
        public IActionResult Home()
        {
            var posts = _context.Posts.ToList();
            return Json(posts);
        }
        
        [Route("/posts/{id}")]
        public IActionResult GetPost(int id)
        {
            var post = _context.Posts.SingleOrDefault(p => p.ID == id);
            return Json(post);
        }
        
        [Route("/about")]
        public IActionResult About()
        {
            var author = _context.Authors.Single(auth => auth.ID == 1);
            return Json(author);
        }
        
        [HttpPost("/posts/add")]
        public IActionResult AddPost([FromBody] NewPost post)
        {
            var author = _context.Authors.Single(auth => auth.ID == 1);
            var postToAdd = new Post
            {
                Title = post.Title,
                Content = post.Content,
                Labels = "unassigned",
                Author = author
            };
            _context.Posts.Add(postToAdd);
            _context.SaveChanges();
            return Json(post);
        }
        
        [HttpPost("/posts/update/{id}")]
        public IActionResult UpdatePost(int id, [FromBody] NewPost post)
        {
            var postToUpdate = _context.Posts.FirstOrDefault(p => p.ID == id);
            postToUpdate.Title = post.Title;
            postToUpdate.Content = post.Content;
            _context.SaveChanges();
            return Json(post);
        }
        
        [HttpPost("/posts/delete/{id}")]
        public IActionResult DeletePost(int id)
        {
            var post = _context.Posts.Single(p => p.ID == id);
            
            _context.Posts.Remove(post);
            _context.SaveChanges();
            return Content("success");
        }
    }

    public class NewPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
    
}