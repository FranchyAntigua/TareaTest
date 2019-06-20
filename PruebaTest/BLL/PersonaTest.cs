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
    public class PersonaTest
    {
        [TestMethod()]

        public void GuardarTest()
        {
            Persona p = new Persona();

            p.PersonaId = 1;
            p.Dni = 1;
            p.Nombre= "Pedro";
            p.Materno = "Juana";
            p.Paterno = "Franci";
            p.FechaNacimiento = DateTime.Now;
            p.Telefono = 1;
            p.Correo = "Juanlopez@";
            p.Sexo = "Masculino";
            p.Idimagen = 1;
            p.Direccion = "Tenares";
            p.Idtipopersona = 1;

            Repositorio<Persona> repositorio = new Repositorio<Persona>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Persona> repositorio = new Repositorio<Persona>();
            bool paso = false;
            Persona p = repositorio.Buscar(1);
            p.Nombre = "franchy";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Persona> repositorio = new Repositorio<Persona>();
            Persona p = repositorio.Buscar(1);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Persona> repositorio = new Repositorio<Persona>();
            List<Persona> lista = new List<Persona>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }


        //[TestMethod()]
        //public void EliminarTest()
        //{
        //    Repositorio<Persona> repositorio = new Repositorio<Persona>();
        //    bool paso = false;
        //    paso = repositorio.Eliminar(1);
        //    Assert.AreEqual(true, paso);
        //}
    }
}
