using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Berk.Models;

namespace Berk.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message> AdminMessages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<VIP> VIPs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
