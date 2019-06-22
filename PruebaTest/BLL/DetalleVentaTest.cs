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
    public class DetalleVentaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            bool paso = false;
            DetalleVenta dv = new DetalleVenta();

            dv.Iddetalleventa = 1;
            dv.Idventa = 1;
            dv.Idproducto = 1;
            dv.Unidades = 1;
            dv.Unidades = 5;
            dv.Costounidad = 50;
            dv.Descuentounidad = 0;
            dv.Total = 250;
            paso = repositorio.Guardar(dv);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            bool estado = false;
            DetalleVenta dv = repositorio.Buscar(1);
            dv.Total = 260;
            estado = repositorio.Modificar(dv);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            DetalleVenta t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            List<DetalleVenta> lista = new List<DetalleVenta>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}
