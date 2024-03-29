﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class CategoriaTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Categoria c = new Categoria();
            c.Idcategoria= 1;
            c.Idcategoria = 1;
            c.Descripcion= "Gerente";

            Repositorio<Categoria> repositorio = new Repositorio<Categoria>();
            bool estado = false;
            estado = repositorio.Guardar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Categoria> repositorio = new Repositorio<Categoria>();
            bool estado = false;
            Categoria c = repositorio.Buscar(1);
            c.Descripcion = "Usuario";
            estado = repositorio.Modificar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Categoria> repositorio = new Repositorio<Categoria>();
            Categoria c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Categoria> repositorio = new Repositorio<Categoria>();
            List<Categoria> lista = new List<Categoria>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Categoria> repositorio = new Repositorio<Categoria>();
            bool estado = false;
            estado = repositorio.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
}
