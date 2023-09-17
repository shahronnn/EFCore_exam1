using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class DataContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
}
