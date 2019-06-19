using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Compra
    {

        [Key]
        public int Idcompra { get; set; }
        public int Idusuario { get; set; }
        public DateTime Fechacompra { get; set; }
        public int Idproveedor { get; set; }
        public int Idtipocomprobante { get; set; }
        public double Costocomprobante { get; set; }
      

        public Compra()
        {
            this.Idcompra = 0;
            this.Idusuario = 0;
            this.Fechacompra = DateTime.Now;
            this.Idproveedor = 0;
            this.Idtipocomprobante = 0;
            this.Costocomprobante = 0;
            

        }
    }
}
