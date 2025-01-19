// src/BloggingPlatform.Application/Interfaces/IPostService.cs
using BloggingPlatform.Domain.Entities;

namespace BloggingPlatform.Application.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<Post> GetPostByIdAsync(Guid id);
        Task CreatePostAsync(Post post);
        Task UpdatePostAsync(Post post);
        Task DeletePostAsync(Guid id);
    }
}