using System;
using System.Collections.Generic;
using System.Text;
using CardinalAuctionWebApplication.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CardinalAuctionWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>()
                   .HasKey(i => i.CompanyId);

            builder.Entity<Bar>()
                   .HasKey(b => b.BarId);
            builder.Entity<Bar>()
                   .HasOne(i => i.Company)
                   .WithMany()
                   .HasForeignKey("CompanyId");

            builder.Entity<Section>()
                   .HasKey(s => s.SectionId);
            builder.Entity<Section>()
                   .HasOne(i => i.Bar)
                   .WithMany()
                   .HasForeignKey("BarId");

            builder.Entity<Table>()
                   .HasKey(t => t.TableId);
            builder.Entity<Table>()
                   .HasOne(i => i.Section)
                   .WithMany()
                   .HasForeignKey("SectionId");

            
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Bar> Bars { get; set; }
        public DbSet<Section> Sections { get; set; }

        public DbSet<Table> Tables { get; set; }
    }
}
