using System.Collections.Generic;

namespace blog.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}