using Domain;
using Infrastructure;
using Infrastructure.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;
    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }
    
    [HttpGet("Get_studens")]
    public List<Student> GetStudents()
    {
        return _studentService.GetStudents();
    }
    [HttpGet("Get_studen")]
    public Student GetStudent(int id)
    {
        return _studentService.GetStudent(id);
    }
    [HttpPost("Add_student")]
    public bool AddStudent(Student student)
    {
        return _studentService.AddStudent(student);
    }
    [HttpPut("Update_student")]
    public bool UpdateStudent(Domain.Student student)
    {
        return _studentService.UpdateStudent(student);
    }
    [HttpDelete("Delete_student")]
    public bool DeleteStudent(int id)
    {
        return _studentService.DeleteStudent(id);
    }
    [HttpGet("Count")]
    public int CountOfStudents()
    {
        return _studentService.CountOfStudents();
    }
}
