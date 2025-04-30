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
        public void ToTest()
        {
            var a = new Square(1, Square.measure.gectar);
            var result = a.To(Square.measure.mSquare);
            Assert.AreEqual("10000 м^2", result.verbose());
        }

        [TestMethod()]
        public void SquarePlusTest()
        {
            var m = new Square(100, Square.measure.mSquare);
            var km = new Square(1, Square.measure.gectar);
            Assert.AreEqual("10100 м^2", (m + km).verbose());

        }
        [TestMethod()]
        public void SquarePlusTest2()
        {
            var a = new Square(5, Square.measure.mSquare);
            var b = new Square(5, Square.measure.mSquare);
            var result = a + b;
            Assert.AreEqual("10 м^2", result.verbose());
        }


        [TestMethod()]
        public void SquareMinusTest()
        {
            var a = new Square(5, Square.measure.mSquare);
            var b = new Square(5, Square.measure.mSquare);
            var result = a - b;
            Assert.AreEqual("0 м^2", result.verbose());
        }
        [TestMethod()]
        public void CompareTest1()
        {
            var a = new Square(5, Square.measure.mSquare);
            var b = new Square(5, Square.measure.mSquare);
            var result = Square.compare(a, b);
            Assert.AreEqual("Площади равны!", result);
        }
        [TestMethod()]
        public void CompareTest2()
        {
            var a = new Square(5, Square.measure.gectar);
            var b = new Square(5, Square.measure.mSquare);
            var result = Square.compare(a, b);
            Assert.AreEqual("Первая площадь больше второй!", result);
        }

        [TestMethod()]
        public void GaDesPlusTest()
        {
            var a = new Square(1, Square.measure.gectar);
            var b = new Square(1, Square.measure.tens);
            var result = a + b;
            Assert.AreEqual("2,0925000000000002 гк", result.verbose());
        }

        [TestMethod()]
        public void GaSotPlusTest()
        {
            var a = new Square(1, Square.measure.gectar);
            var b = new Square(1, Square.measure.hundred);
            var result = a + b;
            Assert.AreEqual("1,01 гк", result.verbose());
        }

        [TestMethod()]
        public void GaMetrMinusTest()
        {
            var a = new Square(5, Square.measure.gectar);
            var b = new Square(5, Square.measure.mSquare);
            var result = a - b;
            Assert.AreEqual("4,9995 гк", result.verbose());
        }

        [TestMethod()]
        public void GaDesMinusTest()
        {
            var a = new Square(5, Square.measure.gectar);
            var b = new Square(1, Square.measure.tens);
            var result = a - b;
            Assert.AreEqual("3,9074999999999998 гк", result.verbose());
        }

        public void GaSotMinusTest()
        {
            var a = new Square(5, Square.measure.gectar);
            var b = new Square(5, Square.measure.hundred);
            var result = a - b;
            Assert.AreEqual("4,95 гк", result.verbose());
        }

        [TestMethod()]
        public void CompareTest3()
        {
            var a = new Square(5, Square.measure.gectar);
            var b = new Square(5, Square.measure.mSquare);
            var result = Square.compare(b, a);
            Assert.AreEqual("Вторая площадь больше первой!", result);
        }

    }
}