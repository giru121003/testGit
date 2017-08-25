using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolManagementSystem.Models
{
    public class Standard
    {
        [Key]
        public int StdID { get; set; }
        [Required(ErrorMessage = "Please pick one value")]
        [Display(Name ="Class")]
        public string StandardName { get; set; }

        public ICollection<Student> Student { get; set; }

    }
}