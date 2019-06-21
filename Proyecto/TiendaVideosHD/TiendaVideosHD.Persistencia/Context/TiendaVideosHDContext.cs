using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models;

namespace TiendaVideosHD.Web.Models
{
    public partial class TiendaVideosHDContext : DbContext
    {
        public TiendaVideosHDContext()
        {
        }

        public TiendaVideosHDContext(DbContextOptions<TiendaVideosHDContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6DG4EDH\\MSSQLSERVER2012;Database=TiendaVideosHD;Trusted_Connection=True");
        }

        public virtual DbSet<Articulo> Articulos { get; set; }
        public virtual DbSet<DatosArticulo> DatosArticulo { get; set; }
        public virtual DbSet<DatosSuscripcion> DatosSuscripcion { get; set; }
        public virtual DbSet<DatosUsuario> DatosUsuario { get; set; }
        public virtual DbSet<Transaccion> Permisos { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Usuario> Suscripciones { get; set; }

        // Unable to generate entity type for table 'dbo.AsociacionRolesPermisos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AsociacionArticuloGenero'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);
		}
    }
}
