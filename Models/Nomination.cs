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
            [Display(Name = "Recognition Number")]
             public int RecognitionId { get; set; }
            //ID of person being     
            [Display(Name = "First Name")]
            public Guid userID { get; set; }
            [ForeignKey(name: "userID")]
            public virtual UserProfile UserProfile { get; set; }

            [Required]
            [Display(Name = "Date of Recognition")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            public DateTime DateOfRecognition { get; set; }
            
            public ICollection<userDetail> userDetails { get; set; }

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
    }
}