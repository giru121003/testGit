using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Models
{
    public class StudentStandard
    {
        
        public int Id { get; set; }
        public string  First { get; set; }
        public string Last { get; set; }

        [Display(Name ="Class")]
        public string Standardname { get; set; }

        [Display(Name = "Contact No")]
        public string Phone { get; set; }
        [Display(Name = "Birthdate")]
        public DateTime DOB { get; set; }
        
    }
}