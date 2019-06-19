using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    class Categoria
    {
        [Key]
        public int Idcategoria { get; set; }
        public string Nombrecategoria { get; set; }
        public string Descripcion { get; set; }

        public Categoria()
        {
            this.Idcategoria = 0;
            this.Nombrecategoria = string.Empty;
            this.Descripcion = string.Empty;
        }
    }
}
