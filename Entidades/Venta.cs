using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Venta
    {
        [Key]
        public int Idventa { get; set; }
        public int Idusuario { get; set; }
        public int Idcliente { get; set; }
        public int Idtipocomprobante { get; set; }
        public DateTime Fechaventa { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Igv { get; set; }
        public double SubTotal { get; set; }
        public double Costoventa { get; set; }

        public Venta()
        {
            this.Idventa = 0;
            this.Idusuario = 0;
            this.Idcliente = 0;
            this.Idtipocomprobante = 0;
            this.Fechaventa = DateTime.Now;
            this.FechaNacimiento = DateTime.Now;
            this.Igv = 0;
            this.SubTotal = 0;
            this.Costoventa = 0;

        }
    }
}
