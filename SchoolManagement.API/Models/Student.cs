using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.API.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
