using NUnit.Framework;
using System;

namespace Task2
{
    [TestFixture]
    public class GeometricShapeTest
    {
        [Test]
        public void AreaCircleRadiusDozens()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(6361.725124, shape.Area(45));
        }

        [Test]
        public void AreaCircleRadiusHundreds()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(172021.04734, shape.Area(234));
        }

        [Test]
        public void AreaCircleRadiusThousands()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(31415.926536, shape.Area(100));
        }

        [Test]
        public void AreaCircleRadiusEqualZero()
        {
            GeometricShape shape = new GeometricShape();
            Assert.Throws<ArgumentOutOfRangeException>(() => shape.Area(0));
        }

        [Test]
        public void AreaCircleRadiusNegative()
        {
            GeometricShape shape = new GeometricShape();
            Assert.Throws<ArgumentOutOfRangeException>(() => shape.Area(-1));
        }

        [Test]
        public void TriangleExist()
        {
            GeometricShape shape = new GeometricShape();
            Assert.Throws<ArgumentException> (() => shape.Area(1,6,8));
        }

        [Test]
        public void TriangleNegativeValue()
        {
            GeometricShape shape = new GeometricShape();
            Assert.Throws<ArgumentException>(() => shape.Area(-6, 6, 8));
        }

        [Test]
        public void AreaTriangleRadiusDozens()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(1788.854382, shape.Area(60,60,80));
        }

        [Test]
        public void AreaTriangleRadiusHundreds()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(13586.983771, shape.Area(123,243,222));
        }

        [Test]
        public void AreaTriangleRadiusThousands()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(732688.036286, shape.Area(1432, 1276, 1223));
        }

        [Test]
        public void TriangleRectangular()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(true, shape.IsRectangular(3, 4, 5));
        }

        [Test]
        public void TriangleNotRectangular()
        {
            GeometricShape shape = new GeometricShape();
            Assert.AreEqual(false, shape.IsRectangular(6, 6, 8));
        }
    }
}
