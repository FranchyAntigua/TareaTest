using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class DetalleVenta
    {
        [Key]
        public int Iddetalleventa { get; set; }
        public int Idventa { get; set; }
        public int Idproducto { get; set; }
        public double Unidades { get; set; }
        public double Costounidad { get; set; }
        public double Descuentounidad { get; set; }
        public double Total { get; set; }

        public DetalleVenta()
        {
            this.Iddetalleventa = 0;
            this.Idventa = 0;
            this.Idproducto = 0;
            this.Unidades = 0;
            this.Costounidad = 0;
            this.Descuentounidad = 0;
            this.Total = 0;

        }
    }
}
