using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Post
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string Title { get; set; }
    [MaxLength(50)]
    public string? Description { get; set; }
    public int Vote { get; set; }
    public DateTime CreatedAt { get; set; }
}
