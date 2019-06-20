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
    public class PermisoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Permiso p = new Permiso();
            p.Idpermiso = 2;
            p.Descripcion = "Pendi";
            p.Funcionalidad= "Soda";

            Repositorio<Permiso> repositorio = new Repositorio<Permiso>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Permiso> repositorio = new Repositorio<Permiso>();
            bool paso = false;
            Permiso p = repositorio.Buscar(2);
            p.Descripcion = " Activo";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Permiso> repositorio = new Repositorio<Permiso>();
            Permiso p = repositorio.Buscar(2);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Permiso> repositorio = new Repositorio<Permiso>();
            List<Permiso> lista = new List<Permiso>();
            lista = repositorio.GetList(p=> true);
            Assert.IsNotNull(lista);
        }


        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Permiso> repositorio = new Repositorio<Permiso>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(2);
        //    Assert.AreEqual(true, paso);
        //}

    }
}
