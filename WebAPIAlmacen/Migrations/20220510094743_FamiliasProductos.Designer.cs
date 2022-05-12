﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIAlmacen;

#nullable disable

namespace WebAPIAlmacen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220510094743_FamiliasProductos")]
    partial class FamiliasProductos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Familia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Familias");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Descatalogado")
                        .HasColumnType("bit");

                    b.Property<int>("FamiliaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("Date");

                    b.Property<string>("FotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("FamiliaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.UbicacionProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Estanteria")
                        .HasColumnType("int");

                    b.Property<int>("Pasillo")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId")
                        .IsUnique();

                    b.ToTable("UbicacionesProductos");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Producto", b =>
                {
                    b.HasOne("WebAPIAlmacen.Entidades.Familia", "Familia")
                        .WithMany("Productos")
                        .HasForeignKey("FamiliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Familia");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.UbicacionProducto", b =>
                {
                    b.HasOne("WebAPIAlmacen.Entidades.Producto", null)
                        .WithOne("UbicacionProducto")
                        .HasForeignKey("WebAPIAlmacen.Entidades.UbicacionProducto", "ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Familia", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Producto", b =>
                {
                    b.Navigation("UbicacionProducto");
                });
#pragma warning restore 612, 618
        }
    }
}
