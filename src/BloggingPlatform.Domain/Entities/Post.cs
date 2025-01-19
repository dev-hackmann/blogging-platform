// src/BloggingPlatform.Domain/Entities/Post.cs
namespace BloggingPlatform.Domain.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}