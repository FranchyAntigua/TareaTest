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
            bool paso = false;
            DetalleVenta dv = repositorio.Buscar(1);
            dv.Total = 260;
            paso = repositorio.Modificar(dv);
            Assert.AreEqual(true, paso);
        }
    }
}
