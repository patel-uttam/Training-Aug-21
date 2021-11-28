using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Day17Practice_Basic_Auth.API.Authentication
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
        
/*        public DbSet<ApplicationUser> applicationUser { set; get; }*/ 
    }
}
