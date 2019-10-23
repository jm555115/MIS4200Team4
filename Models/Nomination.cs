using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team4.Models
{
    public class Nomination
    {

        public bool stewardship { get; set; }
        public bool culture { get; set; }

        public bool deliveryExcellence { get; set; }
        public bool innovation { get; set; }
        public bool greaterGood { get; set; }
        public bool integrityAndOpenness { get; set; }
        public bool balance { get; set; }
    }
}