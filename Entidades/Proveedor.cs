using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Proveedor
    {
        [Key]
        public int Idproveedor { get; set; }
        public int Idpersona { get; set; }

        public Proveedor()
        {
            this.Idproveedor = 0;
            this.Idpersona = 0;

        }
    }
}
