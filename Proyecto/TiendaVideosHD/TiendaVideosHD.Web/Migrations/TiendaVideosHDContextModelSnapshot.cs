﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaVideosHD.Web.Models;

namespace TiendaVideosHD.Web.Migrations
{
    [DbContext(typeof(TiendaVideosHDContext))]
    partial class TiendaVideosHDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DatosArticuloId");

                    b.Property<int>("EstadoArticulo");

                    b.HasKey("Id");

                    b.HasIndex("DatosArticuloId");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Models.DatosArticulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Genero");

                    b.Property<double>("Precio");

                    b.Property<int>("TipoArticulo");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("DatosArticulo");
                });

            modelBuilder.Entity("Models.DatosSuscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Costo");

                    b.Property<double>("Descuento");

                    b.Property<string>("Nombre");

                    b.Property<int>("Tiempo");

                    b.HasKey("Id");

                    b.ToTable("DatosSuscripcion");
                });

            modelBuilder.Entity("Models.DatosUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos");

                    b.Property<string>("Direccion");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombres");

                    b.Property<string>("NumeroCelular");

                    b.Property<string>("NumeroIdentificacion");

                    b.Property<string>("NumeroTelefono");

                    b.HasKey("Id");

                    b.ToTable("DatosUsuario");
                });

            modelBuilder.Entity("Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Models.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticuloId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DatosUsuarioId");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.HasIndex("DatosUsuarioId");

                    b.ToTable("Suscripciones");
                });

            modelBuilder.Entity("Models.Articulo", b =>
                {
                    b.HasOne("Models.DatosArticulo", "DatosArticulo")
                        .WithMany()
                        .HasForeignKey("DatosArticuloId");
                });

            modelBuilder.Entity("Models.Transaccion", b =>
                {
                    b.HasOne("Models.DatosArticulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId");

                    b.HasOne("Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Models.Usuario", b =>
                {
                    b.HasOne("Models.DatosUsuario", "DatosUsuario")
                        .WithMany()
                        .HasForeignKey("DatosUsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}