using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using test1.Models;

namespace test1.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; }

        public DbSet<Tutor> Tutor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>()
              .HasOne(c => c.Tutor)
              .WithMany()
              .HasForeignKey(c => c.TutorId)
              .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
        
    }
}