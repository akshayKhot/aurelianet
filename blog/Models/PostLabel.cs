namespace blog.Models
{
    public class PostLabel
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int LabelId { get; set; }
        public Label Label { get; set; }
    }
}