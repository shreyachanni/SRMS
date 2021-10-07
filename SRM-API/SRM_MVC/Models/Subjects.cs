using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SRM_MVC.Models
{
    
    public class Subjects
    {
        [Required]
        [Column("SubjectId")]
       public int SubjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; }

        [Required]
        [Display(Name = "CourseId")]
        public int cId { get; set; }
        [Required]

        [Display(Name = "bId")]
        public int bId { get; set; }

       

    }
}
