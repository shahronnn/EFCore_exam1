using Domain;

namespace Infrastructure.Services.CourseServices;

public class CourseService : ICourseService
{
    private readonly DataContext _dataContext;


    public CourseService(DataContext dataContext)
    {
        _dataContext = dataContext;

    }
    public bool AddCourse(Course Course)
    {
        _dataContext.Courses.Add(Course);
        return true;
    }

    public int CountOfCourses()
    {
        return _dataContext.Courses.Count();
    }

    public bool DeleteCourse(int id)
    {
        var course = _dataContext.Courses.Find(id);
        _dataContext.Courses.Remove(course);
        return true;
    }

    public Course GetCourse(int id)
    {
        var course = _dataContext.Courses.Find(id);
        return course;
    }

    public List<Course> GetCourses()
    {
        return _dataContext.Courses.ToList();
    }

    public bool UpdateCourse(Course Course)
    {
        _dataContext.Courses.Update(Course);
        return true;
    }

}
