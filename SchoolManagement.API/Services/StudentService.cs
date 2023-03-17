using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.API.Data;
using SchoolManagement.API.Models;
using System.Xml.Linq;

namespace SchoolManagement.API.Services
{
    public class StudentService : IStudentService
    {
        private SchoolManagementDbContext _dbContext;
        public StudentService(SchoolManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddStudent(Student student)
        {
            var name = new SqlParameter("Name", student.Name);
            var dob = new SqlParameter("DateOfBirth", student.DOB);
            var address = new SqlParameter("Address", student.Address);
            var phone = new SqlParameter("Phone", student.Phone);
            var email = new SqlParameter("Email", student.Email);
           var result =  _dbContext.Database.ExecuteSqlRaw("InsertStudent @Name, @DateOfBirth, @Address, @Phone, @Email", name, dob, address,phone,email);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteStudent(int studentId)
        {
            var id = new SqlParameter("Id",studentId);            
            var result = _dbContext.Database.ExecuteSqlRaw("DeleteStudent @Id", id);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public Student GetStudent(int id)
        {
            var studentId = new SqlParameter("Id", id);
            var student = _dbContext.Students.FromSqlRaw("GetStudent @Id",studentId).ToList().FirstOrDefault();
            return student;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = _dbContext.Students.FromSqlRaw("GetAllStudents").ToList();
            return students;
        }

        public bool UpdateStudent(Student student)
        {
            var id = new SqlParameter("Id", student.Id);
            var name = new SqlParameter("Name", student.Name);
            var dob = new SqlParameter("DateOfBirth", student.DOB);
            var address = new SqlParameter("Address", student.Address);
            var phone = new SqlParameter("Phone", student.Phone);
            var email = new SqlParameter("Email", student.Email);
            var result = _dbContext.Database.ExecuteSqlRaw("UpdateStudent @Id, @Name, @DateOfBirth, @Address, @Phone, @Email",id, name, dob, address, phone, email);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
