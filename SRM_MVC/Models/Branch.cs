using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SRM_MVC.Models
{
    public class Branch
    {
        [Required]
        public int BId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

       
        public int CourseId { get; set; }

        

    }
}
