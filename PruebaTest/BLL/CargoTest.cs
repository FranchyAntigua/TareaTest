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
    public class CargoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cargo c = new Cargo();
            c.IdCargo = 2;
            c.NombreCargo= "Administrador";
            c.Idestado = 2;

            Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
            bool estado = false;
            estado = repositorio.Guardar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
            bool estado = false;
            Cargo c = repositorio.Buscar(2);
            c.NombreCargo = "Usuario";
            estado = repositorio.Modificar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
            Cargo c = repositorio.Buscar(2);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
            List<Cargo> lista = new List<Cargo>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
            bool estado = false;
            estado = repositorio.Eliminar(2);
            Assert.AreEqual(true, estado);
        }

    }
}
