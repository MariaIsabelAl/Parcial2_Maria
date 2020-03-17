﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial2_Maria.DAL;

namespace Parcial2_Maria.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200317014714_Llamadas")]
    partial class Llamadas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Parcial2_Maria.Entidades.Llamadas", b =>
                {
                    b.Property<int>("LlamadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("LlamadaId");

                    b.ToTable("Llamadas");

                    b.HasData(
                        new
                        {
                            LlamadaId = 1,
                            Descripcion = "No se"
                        });
                });

            modelBuilder.Entity("Parcial2_Maria.Entidades.LlamadasDetalles", b =>
                {
                    b.Property<int>("LlamadaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LlamadaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Problema")
                        .HasColumnType("TEXT");

                    b.Property<string>("Solucion")
                        .HasColumnType("TEXT");

                    b.HasKey("LlamadaDetalleId");

                    b.HasIndex("LlamadaId");

                    b.ToTable("LlamadasDetalles");

                    b.HasData(
                        new
                        {
                            LlamadaDetalleId = 1,
                            LlamadaId = 1,
                            Problema = "No se",
                            Solucion = "No se"
                        });
                });

            modelBuilder.Entity("Parcial2_Maria.Entidades.LlamadasDetalles", b =>
                {
                    b.HasOne("Parcial2_Maria.Entidades.Llamadas", null)
                        .WithMany("LlamadasDetalles")
                        .HasForeignKey("LlamadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
