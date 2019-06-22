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
    public class MarcaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Marca m = new Marca();
            m.Idmarca = 1;
            m.Nombremarca= "Elias";

            Repositorio<Marca> repositorio = new Repositorio<Marca>();
            bool estado = false;
            estado = repositorio.Guardar(m);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Marca> repositorio = new Repositorio<Marca>();
            bool estado = false;
            Marca m = repositorio.Buscar(1);
            m.Nombremarca= "xtech";
            estado = repositorio.Modificar(m);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Marca> repositorio = new Repositorio<Marca>();
            Marca m = repositorio.Buscar(1);
            Assert.IsNotNull(m);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Marca> repositorio = new Repositorio<Marca>();
            List<Marca> lista = new List<Marca>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Marca> repositorio = new Repositorio<Marca>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}

