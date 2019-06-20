using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaVideosHD.Persistencia
{
    public class AppDbContext: DbContext
    {
        public DbSet<Articulo> Articulos { get; set ; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Articulo>().ToTable("Categories");
            builder.Entity<Articulo>().HasKey(p => p.Id);
            builder.Entity<Articulo>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Articulo>().Property(p => p.EstadoArticulo).IsRequired().HasMaxLength(30);

            builder.Entity<DatosArticulo>().ToTable("Products");
            builder.Entity<DatosArticulo>().HasKey(p => p.Id);
            builder.Entity<DatosArticulo>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<DatosArticulo>().Property(p => p.Genero).IsRequired().HasMaxLength(50);

        }
    }
}
