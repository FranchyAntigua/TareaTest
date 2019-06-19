using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Detallecompra
    {

        [Key]
        public int Iddetallecompra { get; set; }
        public int Idcompra { get; set; }
        public int Idproducto { get; set; }
        public double Unidades { get; set; }
        public double Costounidad { get; set; }
        public double Total { get; set; }

        public Detallecompra()
        {
            this.Iddetallecompra = 0;
            this.Idcompra = 0;
            this.Idproducto = 0;
            this.Unidades = 0;
            this.Costounidad = 0;
            this.Total = 0;

        }
    }
}
