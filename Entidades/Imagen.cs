using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Imagen
    {
        [Key]

        public int Idimagen { get; set; }
        public string rutaimagen { get; set; }

        public Imagen()
        {

            this.Idimagen = 0;
            this.rutaimagen = string.Empty;

        }
    }
}
