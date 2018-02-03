using System.Collections.Generic;

namespace blog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        
        public string Title { get; set; }
        public string Content { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        
    }
}  