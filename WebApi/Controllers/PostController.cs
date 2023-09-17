using Domain;
using Infrastructure.Services.PostServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;


    public PostController(IPostService postService)
    {
        _postService = postService;

    }
    [HttpGet("Get_posts")]
    public List<Post> GetPosts()
    {
        return _postService.GetPosts();
    }
    [HttpGet("Get_post")]
    public Post GetPost(int id)
    {
        return _postService.GetPost(id);
    }
    [HttpPost("Add_post")]
    public bool AddPost(Post post)
    {
        return _postService.AddPost(post);
    }
    [HttpGet("Update_post")]
    public bool UpdatePost(Post post)
    {
        return _postService.UpdatePost(post);
    }
    [HttpGet("Delete_post")]
    public bool DeletePost(int id)
    {
        return _postService.DeletePost(id);
    }
    [HttpGet("Count")]
    public int CountOfPosts()
    {
        return _postService.CountOfPosts();
    }
}
