
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
        public DbSet<Label> Labels { get; set; }
        public DbSet<PostLabel> PostLabels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostLabel>()
                .HasKey(p => new {p.PostId, p.LabelId});
        }
    }
    
}