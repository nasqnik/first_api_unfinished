using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser> // inherit from the DBContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) // ctor + TAB = create a constructor
        : base(dbContextOptions) //passing the piece of data to the top
        {
            
        }

        public DbSet<Stock> Stock{ get; set;} // goes and finds the table Stock
        public DbSet<Comment> Comments{ get; set;} // goes and finds the table Comments
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}