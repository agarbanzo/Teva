using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VOCE_TEVA_Asthma_Single_Page_Website.Models
{
    public class EmailModel
    {
        public EmailModel()
        {
            Subject = "Be the Boss of your Asthma";
        }
        [Required(ErrorMessage = "You have entered an invalid email address. Check the email and try again.")]
        [EmailAddress(ErrorMessage = "You have entered an invalid email address. Check the email and try again.")]
        [Display(Name = "TO:")]
        public string To { get; set; }

        [Required(ErrorMessage = "You have entered an invalid email address. Check the email and try again.")]
        [EmailAddress(ErrorMessage = "You have entered an invalid email address. Check the email and try again.")]
        [Display(Name = "FROM:")]
        public string From { get; set; }

        [Required]
        [Display(Name = "SUBJECT:")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "MESSAGE:")]
        public string Message { get; set; }
    }
}