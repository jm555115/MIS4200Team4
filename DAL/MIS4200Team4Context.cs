using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200Team4.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MIS4200Team4.DAL
{
    public class MIS4200Team4Context : DbContext
    {
        public MIS4200Team4Context() : base("name=DefaultConnection")
        {

         //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Team4Context, MIS4200Team4.DAL.MIS4200Team4Context.Configuration>("DefaultConnection"));

        }
    public DbSet<Nomination> Nomination {get; set;}
    public DbSet<userDetail> UserDetails { get; set; }
    public DbSet<UserProfile> UserProfile { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
    
}
