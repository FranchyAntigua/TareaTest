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
    public class ClienteTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cliente c = new Cliente();
            c.IdCliente = 1;
            c.Nombre = "Alex";

            Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
            bool estado = false;
            estado = repositorio.Guardar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
            bool estado = false;
            Cliente c = repositorio.Buscar(1);
            c.Nombre = "martin";
            estado = repositorio.Modificar(c);
            Assert.AreEqual(true, estado);
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

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }

    }
}
