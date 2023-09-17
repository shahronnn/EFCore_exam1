using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Student
{
    [Key]
    public int Id { get; set; }
    [MaxLength(30)]
    public string FirstName { get; set; }
    [MaxLength(30)]
    public string LastName { get; set; }
    [MaxLength(30)]
    public string? FatherName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Address { get; set; }
    public string Phone { get; set; }
}
