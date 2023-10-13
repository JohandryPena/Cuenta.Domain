﻿// <auto-generated />
using System;
using Cuenta.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cuenta.API.Migrations
{
    [DbContext(typeof(CuentaDbContext))]
    partial class CuentaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Cuenta.Domain.Entitys.Cuentas", b =>
                {
                    b.Property<int>("CuentasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuentasId"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("NumeroCuenta")
                        .HasColumnType("int");

                    b.Property<decimal>("SaldoInicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CuentasId");

                    b.HasIndex("NumeroCuenta")
                        .IsUnique();

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("Cuenta.Domain.Entitys.Movimientos", b =>
                {
                    b.Property<int>("MovimientosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovimientosId"), 1L, 1);

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoMovimineto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MovimientosId");

                    b.HasIndex("CuentaId");

                    b.ToTable("Movimientos");
                });

            modelBuilder.Entity("Cuenta.Domain.Entitys.Movimientos", b =>
                {
                    b.HasOne("Cuenta.Domain.Entitys.Cuentas", "Cuenta")
                        .WithMany("Moviminetos")
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuenta");
                });

            modelBuilder.Entity("Cuenta.Domain.Entitys.Cuentas", b =>
                {
                    b.Navigation("Moviminetos");
                });
#pragma warning restore 612, 618
        }
    }
}
