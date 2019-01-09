using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DSUSoundBoothSchedulerContext : IdentityDbContext<DSUSoundBoothSchedulerUser>
    {
        public DSUSoundBoothSchedulerContext(DbContextOptions<DSUSoundBoothSchedulerContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<DSUSoundBoothSchedulerUser> DSUSoundBoothSchedulerUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
