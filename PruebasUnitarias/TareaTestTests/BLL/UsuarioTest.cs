using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class UsuarioTest
    {
      [TestMethod()]
      public void GuardarTest()
      {
        Usuario u = new Usuario();
        u.Idusuario= 1;
        u.Idusuario = 1;
        u.Nombre = "Ana";
        u.Clave = "1234";

        Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            bool paso = false;
                paso = repositorio.Guardar(u);
                Assert.AreEqual(true, paso);
            }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            bool paso = false;
            Usuario u = repositorio.Buscar(1);
            u.Nombre = "oscar";
            paso = repositorio.Modificar(u);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            Usuario u = repositorio.Buscar(1);
            Assert.IsNotNull(u);
        }


        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            List<Usuario> lista = new List<Usuario>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }

        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}
    }
}
