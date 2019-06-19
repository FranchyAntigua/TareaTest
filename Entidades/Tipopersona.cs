using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Tipopersona
    {
        [Key]
        public int IdTipoPersona { get; set; }
        public string Nombre { get; set; }

        public Tipopersona()
        {
            this.IdTipoPersona = 0;
            this.Nombre = string.Empty;

        }
    }
}
