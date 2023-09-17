using Domain;

namespace Infrastructure;

public interface IStudentService
{
    public List<Student> GetStudents();
    public Student GetStudent(int id);
    public bool AddStudent(Student student);
    public bool UpdateStudent(Student student);
    public bool DeleteStudent(int id);
    public int CountOfStudents();
}
