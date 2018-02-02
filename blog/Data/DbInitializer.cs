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
                    Details = "I am a software developer based in Victoria, BC. I love reading, writing and learning."
                },
                new Author
                {
                    Name = "Amey Dalvi",
                    Email = "amey@gmail.com",
                    Details = "I am an Architect."
                }
            };

            var labels = new Label[]
            {
                new Label
                {
                    Name = "Physics"
                },
                new Label
                {
                    Name = "Mathematics"
                }
            };

            foreach (var author in authors)
            {
                context.Authors.Add(author);
            }

            foreach (var label in labels)
            {
                context.Labels.Add(label);
            }

            context.SaveChanges();
        }
    }
}