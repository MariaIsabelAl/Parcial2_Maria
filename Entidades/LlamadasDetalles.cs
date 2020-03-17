using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2_Maria.Entidades
{
    public class LlamadasDetalles
    {
        [Key]
        public int LlamadaDetalleId { get; set; }
        public int LlamadaId { get; set; }
        public string Problema { get; set; }
        public string Solucion { get; set; }
        
       
        public LlamadasDetalles()
        {
            LlamadaDetalleId = 0;
            LlamadaId = 0;
            Problema = string.Empty;
            Solucion = string.Empty;
        }

        public LlamadasDetalles(int llamadaid,string problema, string solucion)
        {
            LlamadaDetalleId = 0;
            LlamadaId = llamadaid;
            Problema = problema;
            Solucion = solucion;        
        }
    }
}
