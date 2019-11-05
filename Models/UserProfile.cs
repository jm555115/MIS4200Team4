using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Team4.Models
{
    public class UserProfile
    {
       [Key] public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public ICollection<Nomination> Nominations { get; set; }

    }
}