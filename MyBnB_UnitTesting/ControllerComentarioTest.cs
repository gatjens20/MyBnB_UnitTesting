using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyBnb.Controller;

namespace MyBnB_UnitTesting
{
    [TestFixture]
    public class ControllerComentarioTest
    {
        ControllerComentario controllerComentarioObj;

        [TestFixtureSetUp]
        public void Setup()
        {
            controllerComentarioObj = new ControllerComentario();
        }

        [Test]        
        public void realizarComentarioTest()
        {
            try
            {
                controllerComentarioObj.realizarComentario(1, "Nuevo comentario realizado");
            }
            catch
            { }

        }

        [Test]
        public void obtenerComentariosPropiedad_Test()
        {
            try
            {
                controllerComentarioObj.obtenerComentariosPropiedad();
            }
            catch
            { }
        }

        [Test]        
        public void verificarReservacion_Test()
        {

            try
            {
                controllerComentarioObj.verificarReservacion();
            }
            catch
            { }            
        }
    }
}
