﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SisOleoChangeBlazor.Context;

#nullable disable

namespace SisOleoChangeBlazor.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.Filtro", b =>
                {
                    b.Property<int>("FiltroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FiltroId"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TipoFiltro")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("FiltroId");

                    b.ToTable("Filtros");
                });

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.Oleo", b =>
                {
                    b.Property<int>("OleoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OleoId"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TipoOleo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("OleoId");

                    b.ToTable("Oleos");
                });

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.TrocaOleo", b =>
                {
                    b.Property<int>("TrocaOleoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrocaOleoId"), 1L, 1);

                    b.Property<DateTime?>("DataProximaTroca")
                        .HasColumnType("datetime2");

                    b.Property<int>("FiltroId")
                        .HasColumnType("int");

                    b.Property<decimal>("KmAtual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KmProximaTroca")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OleoId")
                        .HasColumnType("int");

                    b.Property<decimal>("QuantidadeOleo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("TrocaOleoId");

                    b.HasIndex("FiltroId");

                    b.HasIndex("OleoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("TrocaOleo");
                });

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VeiculoId"), 1L, 1);

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoVeiculo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("VeiculoId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.TrocaOleo", b =>
                {
                    b.HasOne("SisOleoChangeBlazor.Modal.Filtro", null)
                        .WithMany("TrocaOleos")
                        .HasForeignKey("FiltroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisOleoChangeBlazor.Modal.Oleo", null)
                        .WithMany("TrocaOleos")
                        .HasForeignKey("OleoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisOleoChangeBlazor.Modal.Veiculo", null)
                        .WithMany("TrocaOleos")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.Filtro", b =>
                {
                    b.Navigation("TrocaOleos");
                });

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.Oleo", b =>
                {
                    b.Navigation("TrocaOleos");
                });

            modelBuilder.Entity("SisOleoChangeBlazor.Modal.Veiculo", b =>
                {
                    b.Navigation("TrocaOleos");
                });
#pragma warning restore 612, 618
        }
    }
}