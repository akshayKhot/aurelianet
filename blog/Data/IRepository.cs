using System.Collections.Generic;
using blog.Controllers;
using blog.Models;
using blog.ViewModels;

namespace blog.Data
{
    public interface IRepository
    {
        // Create
        void AddPost(JsonPost post);
        void AddAuthor(JsonAuthor author);
        
        // Read
        IEnumerable<Post> GetAllPosts();
        IEnumerable<Author> GetAllAuthors();
        Post GetPostById(int id);
        Author GetAuthorById(int id);
        IEnumerable<Post> GetAllPostsForAuthor(int id);
        
        // Update
        void UpdatePost(JsonPost post);
        void UpdateAuthor(JsonAuthor author);

        // Delete
        void DeletePost(int id);
        void DeleteAuthor(int id);
    }
}