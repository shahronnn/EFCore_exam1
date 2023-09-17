using Domain;

namespace Infrastructure.Services.PostServices;

public interface IPostService
{
    public List<Post> GetPosts();
    public Post GetPost(int id);
    public bool AddPost(Post post);
    public bool UpdatePost(Post post);
    public bool DeletePost(int id);
    public int CountOfPosts();
}
