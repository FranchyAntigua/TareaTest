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
    public class ImagenTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Imagen i = new Imagen();
            i.Idimagen = 1;
            i.rutaimagen = "123";

            Repositorio<Imagen> repositorio = new Repositorio<Imagen>();
            bool estado = false;
            estado = repositorio.Guardar(i);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Imagen> repositorio = new Repositorio<Imagen>();
            bool estado = false;
            Imagen i = repositorio.Buscar(1);
            i.rutaimagen = "456";
            estado = repositorio.Modificar(i);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Imagen> repositorio = new Repositorio<Imagen>();
            Imagen i = repositorio.Buscar(1);
            Assert.IsNotNull(i);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Imagen> repositorio = new Repositorio<Imagen>();
            List<Imagen> lista = new List<Imagen>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Imagen> repositorio = new Repositorio<Imagen>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }

    }
}
