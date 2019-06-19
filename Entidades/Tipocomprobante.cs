using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Tipocomprobante
    {

        [Key]

        public int tipocomprobante { get; set; }
        public string Nombrecomprobante { get; set; }

        public Tipocomprobante()
        {

            this.tipocomprobante = 0;
            this.Nombrecomprobante = string.Empty;

        }
    }
}
