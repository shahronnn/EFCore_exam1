using Domain;

namespace Infrastructure.Services.PostServices;

public class PostService : IPostService
{
    private readonly DataContext _dataContext;


    public PostService(DataContext dataContext)
    {
        _dataContext = dataContext;

    }
    public bool AddPost(Post post)
    {
        _dataContext.Posts.Add(post);
        return true;
    }

    public int CountOfPosts()
    {
        return _dataContext.Posts.Count();
    }

    public bool DeletePost(int id)
    {
        var post = _dataContext.Posts.Find(id);
        _dataContext.Posts.Remove(post);
        return true;
    }

    public Post GetPost(int id)
    {
        var post = _dataContext.Posts.Find(id);
        return post;
    }

    public List<Post> GetPosts()
    {
        return _dataContext.Posts.ToList();
    }

    public bool UpdatePost(Post post)
    {
        _dataContext.Posts.Update(post);
        return true;
    }

}
