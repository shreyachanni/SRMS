using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SRM_MVC.Models
{
   
    public  class Result
    {
        [Required]
        [Column("ResultId")]
        public int ResultId { get; set; }
 


        [Required]
        [Display(Name = "StudentId")]
        public int StId { get; set; }


        [Required]
        [Display(Name = "SemesterId")]
        public int SemesterId { get; set; }

        [Required]
        [Display(Name = "SubjectId")]
        public int SubId { get; set; }

       
        [Required]
        [StringLength(100)]
        public string ResultScore { get; set; }

        [Required]
        [StringLength(100)]
        public string ResultStatus { get; set; }


    }
}
