using Domain;

namespace Infrastructure.Services.CourseServices;

public interface ICourseService
{
    public List<Course> GetCourses();
    public Course GetCourse(int id);
    public bool AddCourse(Course Course);
    public bool UpdateCourse(Course Course);
    public bool DeleteCourse(int id);
    public int CountOfCourses();
}
