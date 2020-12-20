using System.ComponentModel.DataAnnotations;

namespace ExtProject.Web.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string CaseNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string MiddleName { get; set; }

        [Required]
        public int YearOfBirth { get; set; }

        [Required]
        public int YearOfEntry { get; set; }

        [Required]
        public int YearOfEndingOrDeduction { get; set; }

        [Required]
        public int GraduationOrDeductionRate { get; set; }

        [Required]
        public int GroupId { get; set; }

        public Group Group { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        public bool AvailabilityOfEducationCertificate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}