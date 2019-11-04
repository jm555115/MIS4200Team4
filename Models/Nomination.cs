using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIS4200Team4.Models
{
    public class Nomination
    {
      
            [Key] // the data annotation is necessary because there is a field called, ID,
                  // in the table and it is not the PK for the record
            public int userID { get; set; }
            public virtual UserProfile UserProfile { get; set; }
        //ID of person being recognized
        // public Guid ID { get; set; }
            public int userDetailID { get; set; }
            [ForeignKey(name: "ID")]
            public virtual userDetail userDetails { get; set; }
            [Required]
            [Display(Name = "Date of Recognition")]
            public DateTime DateOfRecognition { get; set; }

            //…
            [Required]
            [Display(Name = "Core Value")]
            public CoreValue award { get; set; }
            public enum CoreValue
            {
                Excellence = 1,
                Culture = 2,
                Integrity = 3,
                Stewardship = 4,
                Innovate = 5,
                Passion = 6,
                Balance = 7
            }

        //public ICollection<userDetail> userDetails { get; set; }

        //public bool stewardship { get; set; }
        //public bool culture { get; set; }

        //public bool deliveryExcellence { get; set; }
        //public bool innovation { get; set; }
        //public bool greaterGood { get; set; }
        //public bool integrityAndOpenness { get; set; }
        //public bool balance { get; set; }
    }
}