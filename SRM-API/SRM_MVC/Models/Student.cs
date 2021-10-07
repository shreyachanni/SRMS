
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SRM_MVC.Models
{
    public class Student
    {
        [Required]
        //[Column("StudentId")]
        public int StudentId { get; set; }



        [Required(ErrorMessage = "Name is Not Empty"), MaxLength(60), MinLength(4)]
        [StringLength(100)]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "Last is Not Empty"), MaxLength(60), MinLength(4)]
        [StringLength(100)]
        public string LastName { get; set; }



        [Required(ErrorMessage = "Email is not Empty")]
        [StringLength(100)]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string StudentEmail { get; set; }







        [Required(ErrorMessage = "Phone Number is Mandatory to Contact you"), MinLength(9), MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }



        [Required(ErrorMessage = "Enter Gender"), MaxLength(10), MinLength(4)]
        [StringLength(50)]
        public string StudentGender { get; set; }


        [Required]
        public string StudentPassword { get; set; }


        [Required]

        public int CourseId { get; set; }

        [Required]

        public int SemesterId { get; set; }

        [Required]
        public int BrId { get; set; }


    }
}
