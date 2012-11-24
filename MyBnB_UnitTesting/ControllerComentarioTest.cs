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
        [ExpectedException(typeof(InvalidOperationException))]
        public void realizarComentarioTest()
        {
            controllerComentarioObj.realizarComentario(1, "¨Nuevo comentario realizado");
        }

    }
}
