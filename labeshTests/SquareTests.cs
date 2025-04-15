using Microsoft.VisualStudio.TestTools.UnitTesting;
using labesh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labesh.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void SquareTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void verboseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SquarePlusNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SquareMinusNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SquareMultiplicationNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SquareDivisionNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToTest()
        {
            var a = new Square(1, Square.measure.tens);
            var result = a.To(Square.measure.mSquare);
            Assert.AreEqual("10925 м^2", result.verbose());
        }

        [TestMethod()]
        public void SquarePlusTest()
        {
            var m = new Square(100, Square.measure.mSquare);
            var km = new Square(1, Square.measure.gectar);
            Assert.AreEqual("10100 м^2", (m+km).verbose());
            
        }


        [TestMethod()]
        public void SquareMinusTest()
        {
            
        }
    }
}