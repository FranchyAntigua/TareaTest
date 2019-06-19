using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
  public  class Cargo
    {
        [Key]
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public int Idestado { get; set; }

        public Cargo()
        {
            this.IdCargo = 0;
            this.NombreCargo = string.Empty;
            this.Idestado = 0;

        }
    }
}
