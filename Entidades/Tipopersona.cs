using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class TipoPersona
    {
        [Key]
        public int IdTipoPersona { get; set; }
        public string Nombre { get; set; }

        public TipoPersona()
        {
            this.IdTipoPersona = 0;
            this.Nombre = string.Empty;

        }
    }
}
