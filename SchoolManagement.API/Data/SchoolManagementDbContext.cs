using Microsoft.EntityFrameworkCore;
using SchoolManagement.API.Models;
namespace SchoolManagement.API.Data
{
    public class SchoolManagementDbContext : DbContext
    {
        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
