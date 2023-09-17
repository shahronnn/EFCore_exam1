using Domain;
using Infrastructure;

namespace Infrastructure.Services.TeacherServies;

public class TeacherService : ITeacherService
{
    private readonly DataContext _dataContext;
    public TeacherService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    public bool AddTeacher(Teacher teacher)
    {
        _dataContext.Teachers.Add(teacher);
        return true;
    }

    public int CountOfTeachers()
    {
        return _dataContext.Teachers.Count();
    }

    public bool DeleteTeacher(int id)
    {
        var teacher = _dataContext.Teachers.Find(id);
        _dataContext.Teachers.Remove(teacher);
        return true;
    }

    public Teacher GetTeacher(int id)
    {
        var teacher = _dataContext.Teachers.Find(id);
        return teacher;
    }

    public List<Teacher> GetTeachers()
    {
        return _dataContext.Teachers.ToList();
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        _dataContext.Teachers.Update(teacher);
        return true;
    }

}
