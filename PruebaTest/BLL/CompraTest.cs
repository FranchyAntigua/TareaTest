using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.BLL;
using TareaTest.Entidades;

namespace PruebaTest.BLL
{
    [TestClass()]
    public  class CompraTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Compra c = new Compra();
            c.Idcompra = 1;
            c.Idusuario = 1;
            c.Fechacompra = DateTime.Now;
            c.Idproveedor = 1;
            c.Idtipocomprobante= 1;
            c.Costocomprobante = 1;

            Repositorio<Compra> repositorio = new Repositorio<Compra>();
            bool estado = false;
            estado = repositorio.Guardar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Compra> repositorio = new Repositorio<Compra>();
            bool estado = false;
            Compra c = repositorio.Buscar(1);
            c.Idusuario = 0;
            estado = repositorio.Modificar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Compra> repositorio = new Repositorio<Compra>();
            Compra c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Compra> repositorio = new Repositorio<Compra>();
            List<Compra> lista = new List<Compra>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Compra> repositorio = new Repositorio<Compra>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}
