using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace PruebasCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstancedList()
        {
            //arrange
            Centralita nuevaCentralita = new Centralita();
            //act
            //assert
            Assert.IsNotNull(nuevaCentralita.Llamadas);
        }
    }
}
