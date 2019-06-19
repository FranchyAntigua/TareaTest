using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string estado { get; set; }

        public Estado()
        {
            this.IdEstado = 0;
            this.FechaInicio = DateTime.Now;
            this.FechaFin = DateTime.Now;
            this.estado = string.Empty;
        }
    }
}
