using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public Cliente()
        {
            this.IdCliente = 0;
            this.Nombre = string.Empty;
        }
    }
}
