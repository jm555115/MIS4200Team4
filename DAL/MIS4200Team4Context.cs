using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200Team4.Models;
using System.Data.Entity;

namespace MIS4200Team4.DAL
{
    public class MIS4200Team4Context : DbContext
    {
    public MIS4200Team4Context() : base ("name=DefaultConnection")
    {

    }
   
    public DbSet<Nomination> Nominations {get; set;}
    public DbSet<userDetail> UserDetail { get; set; }
    public DbSet<UserProfile> Profile { get; set; }
    }
}