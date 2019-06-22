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
    public  class UnidadMedidaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            UnidadMedida u = new UnidadMedida();
            u.Idunidadmedida = 1;
            u.Nombreunidad = "libra";

            Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
            bool estado = false;
            estado = repositorio.Guardar(u);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
            bool estado = false;
            UnidadMedida u = repositorio.Buscar(1);
            u.Nombreunidad = "gramo";
            estado = repositorio.Modificar(u);
            Assert.AreEqual(true, estado);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
            UnidadMedida u = repositorio.Buscar(1);
            Assert.IsNotNull(u);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
            List<UnidadMedida> lista = new List<UnidadMedida>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}
