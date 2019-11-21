using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team4.Models
{
    public class Images
    {
        public Guid imageId { get; set; }
        public string imageName { get; set; }
        public string uploadedImages { get; set; }
        public string imageComments { get; set; }

    }
}