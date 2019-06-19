using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Usuario
    {
        [Key]
        public int Idusuario { get; set; }
        public int Idempleado { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
            this.Idusuario = 0;
            this.Idempleado = 0;
            this.Nombre = string.Empty;
            this.Clave = string.Empty;

        }
    }
}
