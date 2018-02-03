using System.Collections.Generic;

namespace blog.Models
{
    public class Author
    {   
        public int AuthorId { get; set; }
     
        public string Name { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }

        public List<Post> Posts { get; set; }
    }
}