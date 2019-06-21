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
            bool paso = false;
            DetalleCompra dc = new DetalleCompra();

            dc.Idcompra = 1;
            dc.Iddetallecompra = 1;
            dc.Idproducto = 1;
            dc.Unidades = 1;
            dc.Unidades = 5;
            dc.Total = 1000;           
            paso = repositorio.Guardar(dc);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<DetalleCompra> repositorio = new Repositorio<DetalleCompra>();
            bool paso = false;
            DetalleCompra dc = repositorio.Buscar(1);
            dc.Total = 1500;
            paso = repositorio.Modificar(dc);
            Assert.AreEqual(true, paso);
        }
    }
}
