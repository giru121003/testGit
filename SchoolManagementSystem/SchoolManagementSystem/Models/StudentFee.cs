using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolManagementSystem.Models
{
    public class StudentFee
    {


        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter the Fee Type")]
        [Display(Name = "Fee Type")]
        public string FeeType { get; set; }
        [Display(Name = "Admission Fee")]
        public string AdmissionFee {get;set;}
        [Display(Name = "Registration Fee")]
        public string RegistratiomFee { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}