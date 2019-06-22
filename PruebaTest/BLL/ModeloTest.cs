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
    public class ModeloTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Modelo m = new Modelo();
            m.Idmodelo = 1;
            m.Nombremodelo = "XR";

            Repositorio<Modelo> repositorio = new Repositorio<Modelo>();
            bool estado = false;
            estado = repositorio.Guardar(m);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Modelo> repositorio = new Repositorio<Modelo>();
            bool estado = false;
            Modelo m = repositorio.Buscar(1);
            m.Nombremodelo = "XS";
            estado = repositorio.Modificar(m);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Modelo> repositorio = new Repositorio<Modelo>();
            Modelo m = repositorio.Buscar(1);
            Assert.IsNotNull(m);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Modelo> repositorio = new Repositorio<Modelo>();
            List<Modelo> lista = new List<Modelo>();
            lista = repositorio.GetList(m => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Modelo> repositorio = new Repositorio<Modelo>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}
