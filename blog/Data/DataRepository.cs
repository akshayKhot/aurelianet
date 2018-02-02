using System.Collections.Generic;
using System.Linq;
using blog.Controllers;
using blog.Models;

namespace blog.Data
{
    public class DataRepository : IRepository
    {
        private BloggingContext _context { get; }

        public DataRepository(BloggingContext context)
        {
            _context = context;
        }
        
        public void AddPost(Post post)
        {
            var author = _context.Authors.Single(auth => auth.ID == 1);
            var postToAdd = new Post
            {
                Title = post.Title,
                Content = post.Content,
                //LabelId = 0,
                Author = author
            };
            _context.Posts.Add(postToAdd);
            _context.SaveChanges();
        }

        public void AddAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public Author GetAuthorById(int id)
        {
            var author = _context.Authors.Single(auth => auth.ID == id);
            return author;
        }

        public Post GetPostById(int id)
        {
            var post = _context.Posts.SingleOrDefault(p => p.ID == id);
            return post;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            var posts = _context.Posts.ToList();
            return posts;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            throw new System.NotImplementedException();
        }

        public Author UpdateAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public Post UpdatePost(int id, Post post)
        {
            var postToUpdate = _context.Posts.FirstOrDefault(p => p.ID == id);
            postToUpdate.Title = post.Title;
            postToUpdate.Content = post.Content;
            _context.SaveChanges();
            return postToUpdate;
        }

        public void DeleteAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePost(int id)
        {
            var postToDelete = _context.Posts.Single(p => p.ID == id);
            
            _context.Posts.Remove(postToDelete);
            _context.SaveChanges();
        }
    }
}