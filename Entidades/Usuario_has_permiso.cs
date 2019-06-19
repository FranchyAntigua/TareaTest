using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Usuario_has_permiso
    {
        [Key]
        public int Idusuario { get; set; }
        public int Idpermiso { get; set; }

        public Usuario_has_permiso()
        {
            this.Idusuario = 0;
            this.Idpermiso = 0;

        }
    }
}
