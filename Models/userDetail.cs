﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Team4.Models
{
    public class userDetail
    {
        public Guid userDetailID { get; set; }
        [Display(Name = "Number of Nominations")]
        public int numberOfNominations { get; set; }
        public Guid userId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public int RecognitionId { get; set; }
        public virtual Nomination Nomination { get; set; }
       
    }
}