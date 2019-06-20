
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
    public class CargoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cargo c = new Cargo();
            c.IdCargo = 3;
            c.NombreCargo= "Admin";
            c.Idestado = 3;

            Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
            bool paso = false;
            Cargo c = repositorio.Buscar(2);
            c.NombreCargo = "Usuario";            
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
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

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(2);
        //    Assert.AreEqual(true, paso);
        //}

    }
}
