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
    public class DetallecompraTest
   {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<DetalleCompra> repositorio = new Repositorio<DetalleCompra>();
            bool estado = false;
            DetalleCompra dc = new DetalleCompra();

            dc.Idcompra = 1;
            dc.Iddetallecompra = 1;
            dc.Idproducto = 1;
            dc.Unidades = 1;
            dc.Unidades = 5;
            dc.Total = 1000;
            estado = repositorio.Guardar(dc);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<DetalleCompra> repositorio = new Repositorio<DetalleCompra>();
            bool estado = false;
            DetalleCompra dc = repositorio.Buscar(1);
            dc.Total = 1500;
            estado = repositorio.Modificar(dc);
            Assert.AreEqual(true, estado);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<DetalleCompra> repositorio = new Repositorio<DetalleCompra>();
            DetalleCompra t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<DetalleCompra> repositorio = new Repositorio<DetalleCompra>();
            List<DetalleCompra> lista = new List<DetalleCompra>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<DetalleCompra> repositorio = new Repositorio<DetalleCompra>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}
