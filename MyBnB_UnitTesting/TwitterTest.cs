using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyBnb;
using MyBnb.Logica_Negocio;

namespace MyBnB_UnitTesting
{
    [TestFixture]
    public class TwitterTest
    {
        Twitter twitterObj;

        [TestFixtureSetUp]
        public void SetUp()
        {
            twitterObj = new Twitter();
        }

        [Test]        
        public void realizarComentario_Test()
        {
            twitterObj.realizarPublicacion("Se ha registrado una nueva propiedad");
        }

    }
}
