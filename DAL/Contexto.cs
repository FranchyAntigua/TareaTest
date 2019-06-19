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
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Detalleventa> Detalleventa { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Imagen> Imagen { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Tipocomprobante> Tipocomprobante { get; set; }
        public DbSet<Tipopersona> Tipopersona { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venta> Venta{ get; set; }


        public Contexto() : base("ConStr")
        {

        }
    }
}
