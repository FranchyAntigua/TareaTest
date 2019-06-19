using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Marca
    {
        [Key]
        public int Idmarca { get; set; }
        public string Nombremarca { get; set; }

        public Marca()
        {
            this.Idmarca = 0;
            this.Nombremarca = string.Empty;

        }
    }
}
