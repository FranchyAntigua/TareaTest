using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.BLL;
using TareaTest.Entidades;

namespace TareaTestTests.BLL
{
    [TestClass()]
    public class VentaTest
    {

        [TestMethod()]

        public void GuardarTest()
        {
            Venta v = new Venta();

            v.Idventa= 1;
            v.Idusuario = 1;
            v.Idcliente = 1;
            v.Idtipocomprobante = 1;
            v.Fechaventa= DateTime.Now;
            v.Igv = 1;
            v.SubTotal = 1;
            v.Costoventa= 1;

            Repositorio<Venta> repositorio = new Repositorio<Venta>();
            bool paso = false;
            paso = repositorio.Guardar(v);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Venta> repositorio = new Repositorio<Venta>();
            bool paso = false;
            Venta v = repositorio.Buscar(1);
            v.Idusuario = 2;
            paso = repositorio.Modificar(v);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Venta> repositorio = new Repositorio<Venta>();
            Venta t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Venta> repositorio = new Repositorio<Venta>();
            List<Venta> lista = new List<Venta>();
            lista = repositorio.GetList(v => true);
            Assert.IsNotNull(lista);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Venta> repositorio = new Repositorio<Venta>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}


    }
}
