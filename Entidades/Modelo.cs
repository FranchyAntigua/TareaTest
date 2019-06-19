using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Modelo
    {
        [Key]
        public int Idmodelo { get; set; }
        public string Nombremodelo { get; set; }

        public Modelo()
        {
            this.Idmodelo = 0;
            this.Nombremodelo = string.Empty;

        }
    }
}
