using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polynom;

namespace PolynomialTests
{
    [TestClass]
    public class PolynomTests
    {
        [TestMethod]
        public void CheckSizeOfNewPolynom()
        {
            // arrange
            Polynom.Polynom a = new Polynom.Polynom(3);
            int actual = 3;
            // act
            int result = a.GetN;
            // assert
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void CheckSizeOfNewPolynom1()
        {
            // arrange
            Polynom.Polynom a = new Polynom.Polynom(3, 3, 1, 11);
            int actual = 4;
            // act
            int result = a.GetN;
            // assert
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void CheckToStringMethod()
        {
            // arrange
            Polynom.Polynom a = new Polynom.Polynom(3, 3, 1, 11);
            string actual = "3X^3+3X^2+X+11";
            // act
            string result = a.ToString();
            // assert
            Assert.AreEqual(actual, result);
        }


        [TestMethod]
        public void CheckSubstractionMethod()
        {
            // arrange
            Polynom.Polynom a = new Polynom.Polynom(3, 3, 1, 11);
            Polynom.Polynom b = new Polynom.Polynom(3, 0, 0, 11);
            Polynom.Polynom actual = new Polynom.Polynom(6, 3, 1, 0);
            // act
            Polynom.Polynom result = a - b;
            // assert
            Assert.AreEqual(actual.ToString(), result.ToString());
        }
    }
}
