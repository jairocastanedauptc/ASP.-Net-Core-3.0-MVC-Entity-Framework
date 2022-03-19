﻿// <auto-generated />
using System;
using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(DbContexto))]
    [Migration("20220319231748_actualizacion-categoria-codigo-migracion2")]
    partial class actualizacioncategoriacodigomigracion2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirst.Models.Categoria", b =>
                {
                    b.Property<int>("idcategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idcategoria")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("idcategoria");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("CodeFirst.Models.Producto", b =>
                {
                    b.Property<int>("idproducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idproducto")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigo")
                        .HasColumnName("codigo")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<string>("descripcion")
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("idcategoria")
                        .HasColumnName("idcategoria")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<decimal>("precio_venta")
                        .HasColumnName("precio_venta")
                        .HasColumnType("decimal(11,2)");

                    b.Property<int>("stock")
                        .HasColumnName("stock")
                        .HasColumnType("int");

                    b.HasKey("idproducto");

                    b.HasIndex("idcategoria");

                    b.HasIndex("nombre")
                        .IsUnique();

                    b.ToTable("producto");
                });

            modelBuilder.Entity("CodeFirst.Models.Producto", b =>
                {
                    b.HasOne("CodeFirst.Models.Categoria", "categoria")
                        .WithMany("productos")
                        .HasForeignKey("idcategoria")
                        .HasConstraintName("FK_producto_categoria")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
