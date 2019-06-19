using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class TipoComprobante
    {

        [Key]

        public int Idtipocomprobante { get; set; }
        public string Nombrecomprobante { get; set; }

        public TipoComprobante()
        {

            this.Idtipocomprobante = 0;
            this.Nombrecomprobante = string.Empty;

        }
    }
}
