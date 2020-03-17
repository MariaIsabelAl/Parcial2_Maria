using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Parcial2_Maria.Entidades;


namespace Parcial2_Maria.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Llamadas> Llamadas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            optionsBuilder.UseSqlite(@"Data Source= DATA\RParcial2.db");
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Llamadas>().HasData(new Llamadas { LlamadaId = 1, Descripcion="No se"});
           modelBuilder.Entity<LlamadasDetalles>().HasData(new LlamadasDetalles { LlamadaDetalleId = 1, LlamadaId = 1, Problema="No se",Solucion="No se" });
        }
    }
}


