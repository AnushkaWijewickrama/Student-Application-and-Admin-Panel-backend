using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLicenseApi.Models
{
    public class StudentApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Address { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Institute { get; set; }

        [Required]
        public string Intake { get; set; }

        [Required]
        public string CourseTitle { get; set; }

        [Required]
        public string StudentIdCardPath { get; set; } // Path to the uploaded file
    }
}
