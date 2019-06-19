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

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<DetalleCompra> DetalleCompra { get; set; }
        public DbSet<DetalleVenta> Detalleventa { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Imagen> Imagen { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<TipoComprobante> Tipocomprobante { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<TipoPersona> Tipopersona { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venta> Venta{ get; set; }
        public DbSet<Usuario_has_permiso> Usuario_has_permiso { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
