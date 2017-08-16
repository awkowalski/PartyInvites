using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please, enter your name and last name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide e-mail.")]
        [RegularExpression(".+\\@.+\\..+,", ErrorMessage = "Please provide valid e-mail.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Where is your phone number, ey?")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please make up your mind.")]
        public bool? WillAttend { get; set; }
    }
}