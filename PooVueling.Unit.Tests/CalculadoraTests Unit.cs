using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using POWELING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POWELING.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        private ICalculadora mockObject;

        [TestInitialize]
        public void setup()
        {

            var mock = new Mock<ICalculadora>();
            mock.Setup(x => x.Suma(2, 2)).Returns(4);
            mock.Setup(x => x.Resta(4, 2)).Returns(2);
            mock.Setup(x => x.Dividir(4, 2)).Returns(2);
            mock.Setup(x => x.multiplicar(4, 2)).Returns(8);
            mockObject = mock.Object;// Es donde se coje el valor de la variable y se le asigna a MocKObject

        }

        [TestMethod()]
        public void DividirTest()
        {
            var result = mockObject.Dividir(4, 2);
            Assert.AreEqual(2, result);
            
        }

        [TestMethod()]
        public void multiplicarTest()
        {
            var result = mockObject.multiplicar(4, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void RestaTest()
        {
            var result = mockObject.Resta(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void SumaTest()
        {
            var result = mockObject.Suma(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}