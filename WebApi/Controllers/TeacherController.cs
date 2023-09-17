using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService _teacherService;
    public TeacherController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }
    
    [HttpGet("Get_teachers")]
    public List<Teacher> GetTeachers()
    {
        return _teacherService.GetTeachers();
    }
    [HttpGet("Get_studen")]
    public Teacher GetTeacher(int id)
    {
        return _teacherService.GetTeacher(id);
    }
    [HttpPost("Add_Teacher")]
    public bool AddTeacher(Teacher teacher)
    {
        return _teacherService.AddTeacher(teacher);
    }
    [HttpPut("Update_Teacher")]
    public bool UpdateTeacher(Domain.Teacher Teacher)
    {
        return _teacherService.UpdateTeacher(Teacher);
    }
    [HttpDelete("Delete_Teacher")]
    public bool DeleteTeacher(int id)
    {
        return _teacherService.DeleteTeacher(id);
    }
    [HttpGet("Count")]
    public int CountOfTeachers()
    {
        return _teacherService.CountOfTeachers();
    }
}
