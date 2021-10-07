using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SRM_API.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Column("StudentId")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string StudentEmail { get; set; }

        

        [MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string StudentGender { get; set; }

        [Required]
        public string StudentPassword { get; set; }

        [Required]
        [Display(Name = "CourseId")]
        public int CoId { get; set; }

        [ForeignKey("CourseId")]
        public Courses stCourses { get; set; }

        [Required]
        [Display(Name = "SemesterId")]
        public int SemId { get; set; }

        [ForeignKey("SemesterId")]
        public Semester stsemester { get; set; }

        [Display(Name = "BrId")]
        public int BrId { get; set; }

        [ForeignKey("BrId")]
        public Branch stBraches { get; set; }
    }
}
