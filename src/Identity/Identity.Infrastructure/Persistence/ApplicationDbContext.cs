
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Identity.Domain.Entities;
using System;

namespace Identity.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser

     , ApplicationRole,
     Guid,
     ApplicationUserClaim,
     ApplicationUserRole,
     ApplicationUserLogin,
     ApplicationRoleClaim,
     ApplicationUserToken>

    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
