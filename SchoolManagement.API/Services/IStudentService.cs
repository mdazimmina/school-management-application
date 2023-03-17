using SchoolManagement.API.Models;

namespace SchoolManagement.API.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        bool AddStudent(Student student);
        
        bool UpdateStudent(Student student);
        bool DeleteStudent(int id);

    }
}
