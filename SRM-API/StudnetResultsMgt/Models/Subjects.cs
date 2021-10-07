using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SRM_API.Models
{
    [Table("Subjects")]
    public class Subjects
    {
        [Key]
        [Column("SubjectId")]
       public int SubjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; }


        [Display(Name = "CourseId")]
        public int cId { get; set; }

        [ForeignKey("CourseId")]
        public Courses courses { get; set; }


        [Display(Name = "bId")]
        public int bId { get; set; }

        [ForeignKey("bId")]
        public Branch subBraches { get; set; }

    }
}
