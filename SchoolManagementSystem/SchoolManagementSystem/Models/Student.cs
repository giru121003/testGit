using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolManagementSystem.Models
{
    public class Student
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
        [StringLength(50, ErrorMessage = "Length Cannot be Greater Than 50")]
        [Display(Name = "First")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [StringLength(50, ErrorMessage = "Length Cannot be Greater Than 50")]
        [Display(Name = "Last")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Phone  or Mobile Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please Provide Correct Phone Number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Students Date of Birth is Required")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Student's DOB")]
        public DateTime DateofBirth { get; set; }

        [Required]
        public int StdId { get; set; }
        [ForeignKey("StdId")]

        public Standard standard { get; set; }
        [Required]
        public int feeId { get; set; }
        [ForeignKey("feeId")]
        public  StudentFee stuFee { get; set; }
     
    }
}   
