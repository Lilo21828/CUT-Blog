//Group members Names : TN Sibanyoni, WS Mohapi, AR Sihlangu, P.S Dichoetlise; TW Yaso; KE Litabe
//Student Numbers : 222019339 , 222029511,222085102; 216006631; 222032023; 220040472  

//SOD316 Group Assignment 1
//Due Date : 28 April 2024

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASPNETCore_DB.Models
{
    public class Student
    {
        //StudentNumber is the key property for identifying a student (primary key)
        [Key]
        [Display(Name = "Student Number")]
        [Required(ErrorMessage = "Student Number is required.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "The Student Number may " +
            "only be 10 digits")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Only digits are allowed")]
        public string? StudentNumber { get; set; }

        //Name of the student containing no more than 50 characters
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The First Name may not be" +
            " shorter 2 characters or more than 50 characters")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only characters are allowed")]
        public string? FirstName { get; set; }

        //Surname of the student containing no more than 50 characters
        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The Surname may not be" +
            " shorter 2 characters or more than 50 characters")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only characters are allowed")]
        public string? Surname { get; set; }

        //The date of which the student was enrolled to the institution
        [Display(Name = "Enrollment Date")]
        [Required(ErrorMessage = "Enrollment Date is required")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        //A picture that uniquely identifies the students
        [Display(Name = "Photo Identicate")]
        public string? Photo { get; set; }

        //Email address used to contact the student
        [Display(Name = "Contact Mail")]
        [Required(ErrorMessage = "Contact Mail")]
        public string? Email { get; set; }


    }
}
