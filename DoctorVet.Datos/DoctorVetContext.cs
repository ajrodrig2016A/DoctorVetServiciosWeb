using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoctorVet.Datos
{
    public partial class DoctorVetContext : DbContext
    {
        public DoctorVetContext()
            : base("name=DoctorVetWebApi_db")
        {
        }

        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Mascota> Mascota { get; set; }
        public virtual DbSet<Raza> Raza { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>()
                .Property(e => e.diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .Property(e => e.coordenadas)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.numeroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.numeroContacto)
                .IsUnicode(false);

            //modelBuilder.Entity<Cliente>()
            //    .HasMany(e => e.Cita)
            //    .WithRequired(e => e.Cliente)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Cliente>()
            //    .HasMany(e => e.Mascota)
            //    .WithRequired(e => e.Cliente)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mascota>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Mascota>()
                .Property(e => e.genero)
                .IsUnicode(false);

            modelBuilder.Entity<Mascota>()
                .Property(e => e.color)
                .IsUnicode(false);

            //modelBuilder.Entity<Mascota>()
            //    .HasMany(e => e.Cita)
            //    .WithRequired(e => e.Mascota)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Raza>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Raza>()
                .Property(e => e.caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Raza>()
                .Property(e => e.tipoMascota)
                .IsUnicode(false);

            //modelBuilder.Entity<Raza>()
            //    .HasMany(e => e.Mascota)
            //    .WithRequired(e => e.Raza)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.numeroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.rol)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.coordenadas)
                .IsUnicode(false);

            //modelBuilder.Entity<Usuario>()
            //    .HasMany(e => e.Cita)
            //    .WithRequired(e => e.Usuario)
            //    .WillCascadeOnDelete(false);
        }
    }
}
