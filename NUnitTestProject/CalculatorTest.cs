using System;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public static void TestOperations()
        {
            Calculator Calc = new Calculator();
            Assert.AreEqual(44, Calc.Add("12,32"));
        }

        [Test]
        public static void TestOperations2()
        {
            Calculator Calc = new Calculator();
            Assert.AreEqual(94, Calc.Add2("12,3,1,78"));
        }

        [Test]
        public static void TestOperations3()
        {
            Calculator Calc = new Calculator();
            Assert.AreEqual(94, Calc.Add3("12.3-1)78"));
        }

        [Test]
        public static void TestOperations4()
        {
            Calculator Calc = new Calculator();
            Assert.AreNotEqual(94, Calc.Add4("12.3-1)78"));
            Assert.AreEqual(94, Calc.Add4("12.3)1)78"));
        }

        [Test]
        public static void TestOperations5()
        {
            Calculator Calc = new Calculator();
            Assert.AreNotEqual(94, Calc.Add5("12...3*1)-78"));
            Assert.AreNotEqual(94, Calc.Add5("12...3*-1)78"));
            Assert.AreEqual(94, Calc.Add5("12...3-*1-)78"));
            Assert.AreEqual(94, Calc.Add5("12...3*1)78"));
        }

    }
}