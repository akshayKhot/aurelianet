using System.Collections.Generic;
using blog.Controllers;
using blog.Models;

namespace blog.Data
{
    public interface IRepository
    {
        // Create
        void AddPost(Post post);
        void AddAuthor(Author author);
        
        // Read
        Author GetAuthorById(int id);
        Post GetPostById(int id);
        IEnumerable<Post> GetAllPosts();
        IEnumerable<Author> GetAllAuthors();
        
        // Update
        Author UpdateAuthor(Author author);
        Post UpdatePost(int id, Post post);

        // Delete
        void DeleteAuthor(Author author);
        void DeletePost(int id);
    }
}