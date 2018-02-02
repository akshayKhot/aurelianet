using System.Collections.Generic;

namespace blog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public List<PostLabel> PostLabels { get; set; }
    }
}  