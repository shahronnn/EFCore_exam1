using Domain;
using Infrastructure.Services.CourseServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    private readonly ICourseService _courseService;


    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;

    }
    [HttpGet("Get_courses")]
    public List<Course> GetCourses()
    {
        return _courseService.GetCourses();
    }
    [HttpGet("Get_course")]
    public Course GetCourse(int id)
    {
        return _courseService.GetCourse(id);
    }
    [HttpPost("Add_course")]
    public bool AddCourse(Course Course)
    {
        return _courseService.AddCourse(Course);
    }
    [HttpPut("Update_course")]
    public bool UpdateCourse(Course Course)
    {
        return _courseService.UpdateCourse(Course);
    }
    [HttpDelete("Delete_course")]
    public bool DeleteCourse(int id)
    {
        return _courseService.DeleteCourse(id);
    }
    [HttpGet("Count")]
    public int CountOfCourses()
    {
        return _courseService.CountOfCourses();
    }
}
