﻿// <auto-generated />
using System;
using LasPepas.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LasPepas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230305052258_Se agrega Marca a la tabla prendas")]
    partial class SeagregaMarcaalatablaprendas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LasPepas.Entidades.Prenda", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<int>("Marca")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Talle")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Temporada")
                        .HasColumnType("int");

                    b.Property<int>("TipoPrenda")
                        .HasColumnType("int");

                    b.Property<int?>("TipoVenta")
                        .HasColumnType("int");

                    b.Property<decimal?>("VentaContado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("VentaCtaCorriente")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("VentaTarjeta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Prendas");
                });
#pragma warning restore 612, 618
        }
    }
}