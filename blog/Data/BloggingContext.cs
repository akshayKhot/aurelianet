
using blog.Models;
using Microsoft.EntityFrameworkCore;

namespace blog.Data
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {          
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
    
}