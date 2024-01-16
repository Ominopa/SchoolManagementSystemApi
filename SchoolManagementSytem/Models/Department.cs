using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SchoolManagementSytem.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        
        [DisplayName("Department Name")]
        public string? DepartmnetName { get; set; }


        public ICollection<Student>? Students { get; set; }
        public ICollection<Lecturer>? Lecturers { get; set; }

        public ICollection<Course>? Courses { get; set; }
    }
}
