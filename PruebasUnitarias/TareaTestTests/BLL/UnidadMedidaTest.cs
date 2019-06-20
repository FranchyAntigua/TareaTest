﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.BLL;
using TareaTest.Entidades;

namespace TareaTestTests.BLL
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
            bool paso = false;
            paso = repositorio.Guardar(u);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
            bool paso = false;
            UnidadMedida u = repositorio.Buscar(1);
            u.Nombreunidad = "gramo";
            paso = repositorio.Modificar(u);
            Assert.AreEqual(true, paso);
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

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<UnidadMedida> repositorio = new Repositorio<UnidadMedida>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}
    }
}
