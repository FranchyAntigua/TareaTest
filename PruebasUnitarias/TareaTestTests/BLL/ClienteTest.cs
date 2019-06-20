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
    public class ClienteTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cliente c = new Cliente();
            c.IdCliente = 2;
            c.Nombre = "Ale";

            Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
            bool paso = false;
            Cliente c = repositorio.Buscar(1);
            c.Nombre = "martin";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
            Cliente c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
            List<Cliente> lista = new List<Cliente>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}

    }
}
