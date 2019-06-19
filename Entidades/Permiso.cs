using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Permiso
    {
        [Key]
        public int Idpermiso { get; set; }
        public string Descripcion { get; set; }
        public string Funcionalidad { get; set; }

        public Permiso()
        {
            this.Idpermiso = 0;
            this.Descripcion = string.Empty;
            this.Funcionalidad = string.Empty;

        }
    }
}
