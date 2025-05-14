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

        //public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Socio> Socio { get; set; }
        public DbSet<Archivos> Archivos { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<TipoSocio> TipoSocio { get; set; }
        public DbSet<Tutor> Tutor { get; set; }
        public DbSet<ContactoEmergencia> ContactoEmergencia { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<TipoRelacion> TipoRelacion { get; set; }
        public DbSet<TipoCuentaBancaria> TipoCuentaBancaria { get; set; }
        public DbSet<TipoPago> TipoPago { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<MetodoPagoXSocio> MetodoPagoXSocio { get; set; }
        public DbSet<SocioTutor> SocioTutor { get; set; }
        public DbSet<SocioActividad> SocioActividad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación Contacto-Tutor (Uno a Muchos)
            //modelBuilder.Entity<Contacto>()
            //    .HasOne(c => c.Tutor)
            //    .WithMany()
            //    .HasForeignKey(c => c.TutorId)
            //    .OnDelete(DeleteBehavior.Restrict);

            // Relación Socio-TipoDocumento (Muchos a Uno)
            modelBuilder.Entity<Socio>()
                .HasOne(s => s.TipoDocumento)
                .WithMany()
                .HasForeignKey(s => s.TipoDocumentoId);

            // Relación Socio-Archivo (Muchos a Uno)
            modelBuilder.Entity<Socio>()
                .HasOne(s => s.Archivos)
                .WithMany()
                .HasForeignKey(s => s.ArchivosId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Socio-ContactoEmergencia (Muchos a Uno)
            modelBuilder.Entity<Socio>()
                .HasOne(s => s.ContactoEmergencia)
                .WithMany()
                .HasForeignKey(s => s.ContactoEmergenciaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Membresia-Socio (Muchos a Uno)
            modelBuilder.Entity<Membresia>()
                .HasOne(m => m.Socio)
                .WithMany()
                .HasForeignKey(m => m.SocioId);

            // Relación Membresia-SocioReferente (Muchos a Uno)
            modelBuilder.Entity<Membresia>()
                .HasOne(m => m.SocioReferente)
                .WithMany()
                .HasForeignKey(m => m.SocioReferenteId);

            // Relación Membresia-TipoRelacion (Muchos a Uno)
            modelBuilder.Entity<Membresia>()
                .HasOne(m => m.TipoRelacion)
                .WithMany()
                .HasForeignKey(m => m.TipoRelacionId);

            // Relación Membresia-TipoSocio (Muchos a Uno)
            modelBuilder.Entity<Membresia>()
                .HasOne(m => m.TipoSocio)
                .WithMany()
                .HasForeignKey(m => m.TipoSocioId);

            // Relación SocioTutor (Muchos a Muchos)
            modelBuilder.Entity<SocioTutor>()
                .HasOne(st => st.Socio)
                .WithMany()
                .HasForeignKey(st => st.SocioId);

            modelBuilder.Entity<SocioTutor>()
                .HasOne(st => st.Tutor)
                .WithMany()
                .HasForeignKey(st => st.TutorId);

            // Relación SocioActividad (Muchos a Muchos)
            modelBuilder.Entity<SocioActividad>()
                .HasOne(sa => sa.Actividad)
                .WithMany()
                .HasForeignKey(sa => sa.ActividadId);

            modelBuilder.Entity<SocioActividad>()
                .HasOne(sa => sa.Membresia)
                .WithMany()
                .HasForeignKey(sa => sa.MembresiaId);

            // Relación MetodoPago-TipoDocumento (Muchos a Uno)
            modelBuilder.Entity<MetodoPago>()
                .HasOne(mp => mp.TipoDocumento)
                .WithMany()
                .HasForeignKey(mp => mp.TipoDocumentoId);

            // Relación MetodoPago-TipoCuentaBancaria (Muchos a Uno)
            modelBuilder.Entity<MetodoPago>()
                .HasOne(mp => mp.TipoCuentaBancaria)
                .WithMany()
                .HasForeignKey(mp => mp.TipoCuentaId);

            // Relación MetodoPago-TipoPago (Muchos a Uno)
            modelBuilder.Entity<MetodoPago>()
                .HasOne(mp => mp.TipoPago)
                .WithMany()
                .HasForeignKey(mp => mp.TipoPagoId);

            // Relación MetodoPagoXSocio-MetodoPago (Muchos a Uno)
            modelBuilder.Entity<MetodoPagoXSocio>()
                .HasOne(mps => mps.MetodoPago)
                .WithMany()
                .HasForeignKey(mps => mps.MetodoId);

            // Relación MetodoPagoXSocio-Socio (Muchos a Uno)
            modelBuilder.Entity<MetodoPagoXSocio>()
                .HasOne(mps => mps.Socio)
                .WithMany()
                .HasForeignKey(mps => mps.SocioId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
