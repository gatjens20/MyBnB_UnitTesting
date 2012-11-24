using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyBnb.Controller;

namespace MyBnB_UnitTesting
{
    [TestFixture]
    public class ControllerPropiedadTest
    {
        ControllerPropiedades controllerPropiedadObj;

        [TestFixtureSetUp]
        public void Setup()
        {
            controllerPropiedadObj = new ControllerPropiedades();
        }

        [Test]        
        public void obtenerPropiedades_Test()
        {
            String[] pdatos = new String[1];
            String pTipoBusqueda = string.Empty;
            try
            {
                controllerPropiedadObj.obtenerPropiedades(pTipoBusqueda, pdatos);
            }
            catch 
            { }
        }

    }
}
