using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace SchoolManagementSytem.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }



        [DisplayName("Student Number")]
        public string? StudentNumber { get; set; }


        [DisplayName("First Name")]
        public string? FirstName { get; set; }


        [DisplayName("Middle Name")]
        public string? MiddleName { get; set; }


        [DisplayName("Last Name")]
        public string? LastName { get; set; }


        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }


        [StringLength(12, MinimumLength = 9)]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }


        [EmailAddress]
        [DisplayName("Mailing Address")]
        public string? Email { get; set; }

        [DisplayName("Marital Status")]
        public int? MaritalStatusId { get; set; }
       

        [DisplayName("Gender")]
        public int? GenderId { get; set; }
        

        [DisplayName("Country")]
        public int? CountryId { get; set; }
        

        [DisplayName("Programme Stream")]
        public int? ProgStreamId { get; set; }
        
    }
}
