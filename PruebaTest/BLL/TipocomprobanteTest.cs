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
    public class TipocomprobanteTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TipoComprobante t = new TipoComprobante();
            t.Idtipocomprobante = 1;
            t.Nombrecomprobante = "1234";

            Repositorio<TipoComprobante> repositorio = new Repositorio<TipoComprobante>();
            bool paso = false;
            paso = repositorio.Guardar(t);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<TipoComprobante> repositorio = new Repositorio<TipoComprobante>();
            bool paso = false;
            TipoComprobante t = repositorio.Buscar(1);
            t.Nombrecomprobante = "23";
            paso = repositorio.Modificar(t);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<TipoComprobante> repositorio = new Repositorio<TipoComprobante>();
            TipoComprobante t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<TipoComprobante> repositorio = new Repositorio<TipoComprobante>();
            List<TipoComprobante> lista = new List<TipoComprobante>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}

    }
}
