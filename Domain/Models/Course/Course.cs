using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Course
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string Title { get; set; }
    [MaxLength(50)]
    public string? Description { get; set; }
    public decimal? Fee { get; set; }
    public bool? HasDiscount { get; set; }
}
