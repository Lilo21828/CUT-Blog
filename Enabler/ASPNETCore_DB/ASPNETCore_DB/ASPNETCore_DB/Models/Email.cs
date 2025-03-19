//Group members Names : TN Sibanyoni, WS Mohapi, AR Sihlangu
//Student Numbers : 222019339 , 222029511,222085102
//SOD316 Group Assignment 1
//Due Date : 28 April 2024

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_DB.Models
{
    //This class represents an email model for the web application 
    public class Email
    {
        //Subject of the email (required field with error message )
        [Display(Name = "Subject")]
        [Required(ErrorMessage = "This is a required field")]
        public string Subject { get; set; }

        //Body or content of the email (required field with error message)
        [Display(Name = "Message")]
        [Required(ErrorMessage = "This is a required field")]
        public string Body { get; set; }
    }
}
