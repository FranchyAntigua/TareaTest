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
    public class TipopersonaTest
    {

        [TestMethod()]
        public void GuardarTest()
        {
            TipoPersona t = new TipoPersona();
            t.IdTipoPersona = 1;
            t.Nombre = "Arge";
            

            Repositorio<TipoPersona> repositorio = new Repositorio<TipoPersona>();
            bool paso = false;
            paso = repositorio.Guardar(t);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<TipoPersona> repositorio = new Repositorio<TipoPersona>();
            bool paso = false;
            TipoPersona t = repositorio.Buscar(1);
            t.Nombre = "Maria";
            paso = repositorio.Modificar(t);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<TipoPersona> repositorio = new Repositorio<TipoPersona>();
            TipoPersona t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<TipoPersona> repositorio = new Repositorio<TipoPersona>();
            List<TipoPersona> lista = new List<TipoPersona>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }


        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<TipoPersona> repositorio = new Repositorio<TipoPersona>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}

    }
}
