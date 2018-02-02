using System.Collections.Generic;

namespace blog.Models
{
    public class Label
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<PostLabel> PostLabels { get; set; }
    }
}