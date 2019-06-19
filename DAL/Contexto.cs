using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.Entidades;

namespace TareaTest.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estado> Estado { get; set; }
        public Contexto() : base("ConStr")
        {

        }
    }
}
