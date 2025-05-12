using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>()
                .HasKey(c => c.Id);  // Asegúrate de que se defina la clave primaria
        }
    }
}





