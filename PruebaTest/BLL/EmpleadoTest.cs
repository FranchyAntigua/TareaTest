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
            bool estado = false;
            estado = repositorio.Guardar(e);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Empleado> repositorio = new Repositorio<Empleado>();
            bool estado = false;
            Empleado e = repositorio.Buscar(1);
            e.Idestado = 2;
            estado = repositorio.Modificar(e);
            Assert.AreEqual(true, estado);
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


        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Empleado> repositorio = new Repositorio<Empleado>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}


