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
    public class EmpleadoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Empleado e = new Empleado();

            e.Idempleado = 1;
            e.Idestado = 1;
            e.Idcargo = 1;
            e.Idpersona = 1;

            Repositorio<Empleado> repositorio = new Repositorio<Empleado>();
            bool paso = false;
            paso = repositorio.Guardar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Empleado> repositorio = new Repositorio<Empleado>();
            bool paso = false;
            Empleado e = repositorio.Buscar(1);
            e.Idestado = 2;
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Empleado> repositorio = new Repositorio<Empleado>();
            Empleado e = repositorio.Buscar(1);
            Assert.IsNotNull(e);
        }


        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Empleado> repositorio = new Repositorio<Empleado>();
            List<Empleado> lista = new List<Empleado>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }


        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Empleado> repositorio = new Repositorio<Empleado>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}
    }
}


