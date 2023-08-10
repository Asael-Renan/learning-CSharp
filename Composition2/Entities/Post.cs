namespace Composition2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String? Title { get; set; }
        public String? Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string? title, string? content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment) {
            Comments.Add(comment);
        }
    }
}