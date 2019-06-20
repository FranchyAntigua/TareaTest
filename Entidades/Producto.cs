using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
        public class Producto
        {

            [Key]
            public int Idproducto { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fechafabricacion { get; set; }
            public double Costocompra{ get; set; }
            public double Stock { get; set; }
            public int Idunidadmedida { get; set; }
            public int Idimagen { get; set; }
            public int Idcategoria{ get; set; }
            public int Idmarca { get; set; }
            public int Idmodelo { get; set; }

        public Producto()
            {
                this.Idproducto = 0;
                this.Nombre = string.Empty;
                this.Descripcion = string.Empty;
                this.Fechafabricacion = DateTime.Now;
                this.Costocompra = 0;
                this.Stock = 0;
                this.Idunidadmedida = 0;
                this.Idimagen = 0;
                this.Idcategoria = 0;
                this.Idmarca = 0;
                this.Idmodelo = 0;

            }
        }
}
