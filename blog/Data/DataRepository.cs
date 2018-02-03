using System.Collections.Generic;
using System.Linq;
using blog.Controllers;
using blog.Models;
using blog.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace blog.Data
{
    public class DataRepository : IRepository
    {
        private BloggingContext _context { get; }

        public DataRepository(BloggingContext context)
        {
            _context = context;
        }
        
        // Create
        public void AddPost(JsonPost post)
        {
            var author = _context.Authors
                                 .Include(auth => auth.Posts)
                                 .FirstOrDefault(auth => auth.AuthorId == post.AuthorId);
            var postToAdd = new Post
            {
                Title = post.Title,
                Content = post.Content
            };
            author.Posts.Add(postToAdd);
            _context.SaveChanges();
        }

        public void AddAuthor(JsonAuthor author)
        {
            var authorToAdd = new Author
            {
                Name = author.Name,
                Email = author.Email,
                Details = author.Details
            };
            _context.Authors.Add(authorToAdd);
            _context.SaveChanges();
        }
        
        // Read
        public IEnumerable<Post> GetAllPosts()
        {
            var posts = _context.Posts.ToList();
            return posts;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            var authors = _context.Authors.Include(auth => auth.Posts).ToList();
            return authors;
        }
        
        public Post GetPostById(int id)
        {
            var post = _context.Posts.SingleOrDefault(p => p.PostId == id);
            return post;
        }
        
        public Author GetAuthorById(int id)
        {
            var author = _context.Authors.Single(auth => auth.AuthorId == id);
            return author;
        }

        public IEnumerable<Post> GetAllPostsForAuthor(int id)
        {
            var author = _context.Authors
                                 .Include(auth => auth.Posts)
                                 .FirstOrDefault(auth => auth.AuthorId == id);
            var posts = author.Posts.ToList();
            return posts;
        }

    
        // Update
        public void UpdatePost(Post post)
        {
            var postToUpdate = _context.Posts.FirstOrDefault(p => p.PostId == post.PostId);
            postToUpdate.Title = post.Title;
            postToUpdate.Content = post.Content;
            _context.SaveChanges();
        }
        
        public void UpdateAuthor(Author author)
        {
            var authorToUpdate = _context.Authors.FirstOrDefault(auth => auth.AuthorId == author.AuthorId);
            authorToUpdate.Name = author.Name;
            authorToUpdate.Email = author.Email;
            authorToUpdate.Details = author.Details;
            _context.SaveChanges();
        }

        
        // Delete
        public void DeletePost(int id)
        {
            var postToDelete = _context.Posts.SingleOrDefault(p => p.PostId == id);
            
            _context.Posts.Remove(postToDelete);
            _context.SaveChanges();
        }
        
        public void DeleteAuthor(int id)
        {
            var authorToDelete = _context.Authors.SingleOrDefault(auth => auth.AuthorId == id);
            
            _context.Authors.Remove(authorToDelete);
            _context.SaveChanges();
        }

    }
}