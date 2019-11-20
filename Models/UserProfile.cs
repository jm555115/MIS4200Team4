using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Team4.Models
{
    public class UserProfile
    {
       [Key] public Guid userID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "E-Mail")]
        public string email { get; set; }
        public string fullName { get { return lastName + ", " + firstName; } }

        public ICollection<Nomination> Nominations { get; set; }

    }
}