using System.Collections.Generic;
using System.Linq;
using blog.Models;

namespace blog.Data
{
    public class DbInitializer
    {
        public static void Initialize(BloggingContext context)
        {
            context.Database.EnsureCreated();

            if (context.Authors.Any())
            {
                return;
            }

            var authors = new Author[]
            {
                new Author
                {
                    Name = "Akshay Khot",
                    Email = "akshay.7277@gmail.com",
                    Details = "I am a software developer based in Victoria, BC. I love reading, writing and learning.",
                    Posts = new List<Post>
                    {
                        new Post { Title = "Hello World", Content = "Akshay's First post. Let's see how this goes."},
                        new Post { Title = "Another Post", Content = "This blog focuses on Science."}
                    }
                },
                new Author
                {
                    Name = "Amey Dalvi",
                    Email = "amey@gmail.com",
                    Details = "I am an Architect.",
                    Posts = new List<Post>
                    {
                        new Post { Title = "Architecture", Content = "This is an architectural blog. "}
                    }
                }
            };

            context.Authors.AddRange(authors);

            context.SaveChanges();
        }
    }
}