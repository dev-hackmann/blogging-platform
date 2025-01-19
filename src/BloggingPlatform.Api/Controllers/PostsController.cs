using BloggingPlatform.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs()
        {
            var result = await _postService.GetAllPostsAsync();
            return Ok(result);
        }
    }
}