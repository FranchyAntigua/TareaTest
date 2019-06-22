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
            bool estado = false; 
            Estado e = new Estado();
            e.IdEstado = 2;
            e.FechaInicio = DateTime.Now;
            e.FechaFin = DateTime.Now;
            e.estado = "Excelente";

            estado = repositorio.Guardar(e);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Estado> repositorio = new Repositorio<Estado>();
            bool estado = false;
            Estado e = repositorio.Buscar(2);
            e.FechaFin = DateTime.Now;
            e.estado = "Mas o menos";

            estado = repositorio.Modificar(e);
            Assert.AreEqual(true, estado);
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

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Estado> repositorio = new Repositorio<Estado>();
            bool estado = false;
            estado = repositorio.Eliminar(2);
            Assert.AreEqual(true, estado);
        }
    }
}