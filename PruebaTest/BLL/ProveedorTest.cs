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
    public class ProveedorTest
    {

        [TestMethod()]
        public void GuardarTest()
        {
            Proveedor p= new Proveedor();
            p.Idproveedor = 1;
            p.Idpersona = 1;

            Repositorio<Proveedor> repositorio = new Repositorio<Proveedor>();
            bool estado = false;
            estado = repositorio.Guardar(p);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Proveedor> repositorio = new Repositorio<Proveedor>();
            bool estado = false;
            Proveedor p = repositorio.Buscar(1);
            p.Idpersona = 2;
            estado = repositorio.Modificar(p);
            Assert.AreEqual(true, estado);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Proveedor> repositorio = new Repositorio<Proveedor>();
            Proveedor p = repositorio.Buscar(1);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Proveedor> repositorio = new Repositorio<Proveedor>();
            List<Proveedor> lista = new List<Proveedor>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Proveedor> repositorio = new Repositorio<Proveedor>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}
