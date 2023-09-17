using Domain;
using Infrastructure;

namespace Infrastructure;

public class StudentService : IStudentService
{
    private readonly DataContext _dataContext;
    public StudentService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    public bool AddStudent(Student student)
    {
        _dataContext.Students.Add(student);
        _dataContext.SaveChanges();
        return true;
    }

    public int CountOfStudents()
    {
        return _dataContext.Students.Count();
    }

    public bool DeleteStudent(int id)
    {
        var student = _dataContext.Students.Find(id);
        _dataContext.Students.Remove(student);
        _dataContext.SaveChanges();
        return true;
    }

    public Student GetStudent(int id)
    {
        var student = _dataContext.Students.Find(id);
        return student;
    }

    public List<Student> GetStudents()
    {
        return _dataContext.Students.ToList();
    }

    public bool UpdateStudent(Student student)
    {
        _dataContext.Students.Update(student);
        _dataContext.SaveChanges();
        return true;
    }

}
