using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSytem.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string? CourseCode { get; set; }

        public string? Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int? DepartmentId { get; set; }

        
    }
}
