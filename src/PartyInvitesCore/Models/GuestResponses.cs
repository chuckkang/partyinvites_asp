using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitesCore.Models
{
    public class GuestResponses
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name{ get; set; }

        [Required(ErrorMessage = "Please enter your email address in the correct format.")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you will attend.")]
        public bool? WillAttend { get; set; }
    }
}
