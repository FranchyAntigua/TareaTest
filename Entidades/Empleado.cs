using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Empleado
    {

        [Key]
        public int Idempleado { get; set; }
        public int Idestado { get; set; }
        public int Idcargo { get; set; }
        public int Idpersona { get; set; }


        public Empleado()
        {
            this.Idempleado = 0;
            this.Idestado = 0;
            this.Idcargo = 0;
            this.Idpersona = 0;

        }
    }
}
