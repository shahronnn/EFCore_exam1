using Domain;

namespace Infrastructure;

public interface ITeacherService
{
    public List<Teacher> GetTeachers();
    public Teacher GetTeacher(int id);
    public bool AddTeacher(Teacher teacher);
    public bool UpdateTeacher(Teacher teacher);
    public bool DeleteTeacher(int id);
    public int CountOfTeachers();
}
