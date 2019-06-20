using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.Entidades;

namespace PruebaTest.BLL

{
    [TestClass()]
    public class EstadoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Estado> repositorio = new Repositorio<Estado>();
            bool paso = false;
            Estado e = new Estado();
            e.IdEstado = 2;
            e.FechaInicio = DateTime.Now;
            e.FechaFin = DateTime.Now;
            e.estado = "Excelente";

            paso = repositorio.Guardar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Estado> repositorio = new Repositorio<Estado>();
            bool paso = false;
            Estado e = repositorio.Buscar(2);
            e.FechaFin = DateTime.Now;
            e.estado = "Mas o menos";

            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Estado> repositorio = new Repositorio<Estado>();
            Estado e = repositorio.Buscar(2);
            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Estado> repositorio = new Repositorio<Estado>();
            List<Estado> lista = new List<Estado>();
            lista = repositorio.GetList(e=> true);
            Assert.IsNotNull(lista);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Estado> repositorio = new Repositorio<Estado>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}
    }
}