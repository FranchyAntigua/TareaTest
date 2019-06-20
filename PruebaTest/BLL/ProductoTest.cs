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
    public class ProductoTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Producto p = new Producto();

            p.Idproducto = 1;
            p.Nombre = "Pedro";
            p.Descripcion = "Juego";
            p.Fechafabricacion = DateTime.Now;
            p.Costocompra= 1;
            p.Stock = 1;
            p.Idunidadmedida= 1;
            p.Idimagen = 1;
            p.Idcategoria = 1;
            p.Idmarca = 1;
            p.Idmodelo= 1;

            Repositorio<Producto> repositorio = new Repositorio<Producto>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Producto> repositorio = new Repositorio<Producto>();
            bool paso = false;
            Producto p = repositorio.Buscar(1);
            p.Descripcion = "Mlb";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Producto> repositorio = new Repositorio<Producto>();
            Producto p = repositorio.Buscar(1);
            Assert.IsNotNull(p);
        }


        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Producto> repositorio = new Repositorio<Producto>();
            List<Producto> lista = new List<Producto>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Cargo> repositorio = new Repositorio<Cargo>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}
    }
}
