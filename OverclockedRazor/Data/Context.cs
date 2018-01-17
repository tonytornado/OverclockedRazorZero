using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverclockedRazor.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Client> Clients { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    ModelBuilder.Entity<Client>().ToTable("Clients");
        //    ModelBuilder.Entity<Newsletter>().ToTable("Newsletters");
        //}
    }
}
