using System;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    class CalculatorTest
    {
        public void Errors(double sum, string numbers, Calculator Calc)
        {
            try
            {
                Assert.AreEqual(sum, Calc.Add(numbers));
            }
            catch (Exception2)
            {
                
            }
        }
        public void Errors2(double sum, string numbers, Calculator Calc)
        {
            try
            {
                Assert.AreEqual(sum, Calc.Add2(numbers));
            }
            catch (Exception2)
            {

            }
        }
        public void Errors3(double sum, string numbers, Calculator Calc)
        {
            try
            {
                Assert.AreEqual(sum, Calc.Add3(numbers));
            }
            catch (Exception2)
            {

            }
        }
        public void Errors4(double sum, string numbers, Calculator Calc)
        {
            try
            {
                Assert.AreEqual(sum, Calc.Add4(numbers));
            }
            catch (Exception2)
            {

            }
        }
        public void Errors5(double sum, string numbers, Calculator Calc)
        {
            try
            {
                Assert.AreEqual(sum, Calc.Add5(numbers));
            }
            catch (Exception2)
            {

            }
        }
        [Test]
        public static void TestOperations()
        {
            Calculator Calc = new Calculator();
            CalculatorTest CalcTest = new CalculatorTest();
            CalcTest.Errors(1,"", Calc);
            CalcTest.Errors(1, "_", Calc);
            CalcTest.Errors(1, "+", Calc);
            CalcTest.Errors(1, "-", Calc);
            CalcTest.Errors(1, "++", Calc);
            CalcTest.Errors(1, "--", Calc);
            CalcTest.Errors(1, "12", Calc);
            CalcTest.Errors(1, "12.5", Calc);
            CalcTest.Errors(1, "-12", Calc);
            CalcTest.Errors(-0.5, "12.5,-13", Calc);
            CalcTest.Errors(1, "12.5-13", Calc);
            CalcTest.Errors(1, "12,5-13", Calc);
            CalcTest.Errors(1, "s1,2", Calc);
            CalcTest.Errors(1, "12,34Ы", Calc);
            CalcTest.Errors(1, "-1,1-", Calc);
            CalcTest.Errors(1, ",", Calc);
            CalcTest.Errors(1, "1,", Calc);
            CalcTest.Errors(1, ",1", Calc);
            CalcTest.Errors(1, "1, -", Calc);
            CalcTest.Errors(1, "-,1", Calc);
            CalcTest.Errors(4, "-3,+7", Calc);
            CalcTest.Errors(1, "12.5,-13+25.00,1E-1,0", Calc);
            CalcTest.Errors(1, "12.5,-13,+25.00,1E-1,0", Calc);
            CalcTest.Errors(1, "12.5,13,+25.00,1E-1,0", Calc);
            CalcTest.Errors(0, "0,0", Calc);
            CalcTest.Errors(0, "-0,+0", Calc);
            CalcTest.Errors(1, "-1 2 3 4", Calc);
            CalcTest.Errors(1, "1 2 3 4", Calc);
            CalcTest.Errors(1, "1,2,3,z", Calc);
            CalcTest.Errors(1, "1,2,3,z,4", Calc);
            CalcTest.Errors(1, "1,-1,--1", Calc);
            CalcTest.Errors(1, "1,-1,1,1,-1", Calc);
            CalcTest.Errors(1, "1,-1,#,1,-1", Calc);
            CalcTest.Errors(1, "0,,,", Calc);
            CalcTest.Errors(1, "12.5 13#+25.00$1E-1%0", Calc);
            CalcTest.Errors(1, "@@#", Calc);
        }
        [Test]
        public static void TestOperations2()
        {
            Calculator Calc = new Calculator();
            CalculatorTest CalcTest = new CalculatorTest();
            CalcTest.Errors2(1, "", Calc);
            CalcTest.Errors2(1, "_", Calc);
            CalcTest.Errors2(1, "+", Calc);
            CalcTest.Errors2(1, "-", Calc);
            CalcTest.Errors2(1, "++", Calc);
            CalcTest.Errors2(1, "--", Calc);
            CalcTest.Errors2(1, "12", Calc);
            CalcTest.Errors2(1, "12.5", Calc);
            CalcTest.Errors2(1, "-12", Calc);
            CalcTest.Errors2(-0.5, "12.5,-13", Calc);
            CalcTest.Errors2(1, "12.5-13", Calc);
            CalcTest.Errors2(1, "12,5-13", Calc);
            CalcTest.Errors2(1, "s1,2", Calc);
            CalcTest.Errors2(1, "12,34Ы", Calc);
            CalcTest.Errors2(1, "-1,1-", Calc);
            CalcTest.Errors2(1, ",", Calc);
            CalcTest.Errors2(1, "1,", Calc);
            CalcTest.Errors2(1, ",1", Calc);
            CalcTest.Errors2(1, "1, -", Calc);
            CalcTest.Errors2(1, "-,1", Calc);
            CalcTest.Errors2(4, "-3,+7", Calc);
            CalcTest.Errors2(1, "12.5,-13+25.00,1E-1,0", Calc);
            CalcTest.Errors2(24.6, "12.5,-13,+25.00,1E-1,0", Calc);
            CalcTest.Errors2(50.6, "12.5,13,+25.00,1E-1,0", Calc);
            CalcTest.Errors2(0, "0,0", Calc);
            CalcTest.Errors2(0, "-0,+0", Calc);
            CalcTest.Errors2(1, "-1 2 3 4", Calc);
            CalcTest.Errors2(1, "1 2 3 4", Calc);
            CalcTest.Errors2(1, "1,2,3,z", Calc);
            CalcTest.Errors2(1, "1,2,3,z,4", Calc);
            CalcTest.Errors2(1, "1,-1,--1", Calc);
            CalcTest.Errors2(1, "1,-1,1,1,-1", Calc);
            CalcTest.Errors2(1, "1,-1,#,1,-1", Calc);
            CalcTest.Errors2(1, "0,,,", Calc);
            CalcTest.Errors2(1, "12.5 13#+25.00$1E-1%0", Calc);
            CalcTest.Errors2(1, "@@#", Calc);
        }
        [Test]
        public static void TestOperations3()
        {
            Calculator Calc = new Calculator();
            CalculatorTest CalcTest = new CalculatorTest();
            CalcTest.Errors3(1, "", Calc);
            CalcTest.Errors3(1, "_", Calc);
            CalcTest.Errors3(1, "+", Calc);
            CalcTest.Errors3(1, "-", Calc);
            CalcTest.Errors3(1, "++", Calc);
            CalcTest.Errors3(1, "--", Calc);
            CalcTest.Errors3(1, "12", Calc);
            CalcTest.Errors3(1, "12.5", Calc);
            CalcTest.Errors3(1, "-12", Calc);
            CalcTest.Errors3(-0.5, "12.5,-13", Calc);
            CalcTest.Errors3(1, "12.5-13", Calc);
            CalcTest.Errors3(1, "12,5-13", Calc);
            CalcTest.Errors3(1, "s1,2", Calc);
            CalcTest.Errors3(1, "12,34Ы", Calc);
            CalcTest.Errors3(1, "-1,1-", Calc);
            CalcTest.Errors3(1, ",", Calc);
            CalcTest.Errors3(1, "1,", Calc);
            CalcTest.Errors3(1, ",1", Calc);
            CalcTest.Errors3(1, "1, -", Calc);
            CalcTest.Errors3(1, "-,1", Calc);
            CalcTest.Errors3(4, "-3,+7", Calc);
            CalcTest.Errors3(1, "12.5,-13+25.00,1E-1,0", Calc);
            CalcTest.Errors3(24.6, "12.5,-13,+25.00,1E-1,0", Calc);
            CalcTest.Errors3(50.6, "12.5,13,+25.00,1E-1,0", Calc);
            CalcTest.Errors3(0, "0,0", Calc);
            CalcTest.Errors3(0, "-0,+0", Calc);
            CalcTest.Errors3(8, "-1 2 3 4", Calc);
            CalcTest.Errors3(10, "1 2 3 4", Calc);
            CalcTest.Errors3(1, "1,2,3,z", Calc);
            CalcTest.Errors3(1, "1,2,3,z,4", Calc);
            CalcTest.Errors3(1, "1,-1,--1", Calc);
            CalcTest.Errors3(1, "1,-1,1,1,-1", Calc);
            CalcTest.Errors3(1, "1,-1,#,1,-1", Calc);
            CalcTest.Errors3(1, "0,,,", Calc);
            CalcTest.Errors3(1, "12.5  13#+25.00$1E-1%0", Calc);
            CalcTest.Errors3(1, "@@#", Calc);
        }   
        [Test]
        public static void TestOperations4()
        {
            Calculator Calc = new Calculator();
            CalculatorTest CalcTest = new CalculatorTest();
            CalcTest.Errors4(1, "", Calc);
            CalcTest.Errors4(1, "_", Calc);
            CalcTest.Errors4(1, "+", Calc);
            CalcTest.Errors4(1, "-", Calc);
            CalcTest.Errors4(1, "++", Calc);
            CalcTest.Errors4(1, "--", Calc);
            CalcTest.Errors4(1, "12", Calc);
            CalcTest.Errors4(1, "12.5", Calc);
            CalcTest.Errors4(1, "-12", Calc);
            CalcTest.Errors4(-0.5, "12.5,-13", Calc);
            CalcTest.Errors4(1, "12.5-13", Calc);
            CalcTest.Errors4(1, "12,5-13", Calc);
            CalcTest.Errors4(1, "s1,2", Calc);
            CalcTest.Errors4(1, "12,34Ы", Calc);
            CalcTest.Errors4(1, "-1,1-", Calc);
            CalcTest.Errors4(1, ",", Calc);
            CalcTest.Errors4(1, "1,", Calc);
            CalcTest.Errors4(1, ",1", Calc);
            CalcTest.Errors4(1, "1, -", Calc);
            CalcTest.Errors4(1, "-,1", Calc);
            CalcTest.Errors4(1, "-3,+7", Calc);
            CalcTest.Errors4(1, "12.5,-13+25.00,1E-1,0", Calc);
            CalcTest.Errors4(1, "12.5,-13,+25.00,1E-1,0", Calc);
            CalcTest.Errors4(50.6, "12.5,13,+25.00,1E-1,0", Calc);
            CalcTest.Errors4(0, "0,0", Calc);
            CalcTest.Errors4(0, "-0,+0", Calc);
            CalcTest.Errors4(1, "-1 2 3 4", Calc);
            CalcTest.Errors4(10, "1 2 3 4", Calc);
            CalcTest.Errors4(1, "1,2,3,z", Calc);
            CalcTest.Errors4(1, "1,2,3,z,4", Calc);
            CalcTest.Errors4(1, "1,-1,--1", Calc);
            CalcTest.Errors4(1, "1,-1,1,1,-1", Calc);
            CalcTest.Errors4(1, "1,-1,#,1,-1", Calc);
            CalcTest.Errors4(1, "0,,,", Calc);
            CalcTest.Errors4(1, "12.5  13#+25.00$1E-1%0", Calc);
            CalcTest.Errors4(1, "@@#", Calc);
        }
        [Test]
        public static void TestOperations5()
        {
            Calculator Calc = new Calculator();
            CalculatorTest CalcTest = new CalculatorTest();
            CalcTest.Errors5(1, "", Calc);
            CalcTest.Errors5(1, "_", Calc);
            CalcTest.Errors5(1, "+", Calc);
            CalcTest.Errors5(1, "-", Calc);
            CalcTest.Errors5(1, "++", Calc);
            CalcTest.Errors5(1, "--", Calc);
            CalcTest.Errors5(1, "12", Calc);
            CalcTest.Errors5(1, "12.5", Calc);
            CalcTest.Errors5(1, "-12", Calc);
            CalcTest.Errors5(-0.5, "12.5,-13", Calc);
            CalcTest.Errors5(1, "12.5-13", Calc);
            CalcTest.Errors5(1, "12,5-13", Calc);
            CalcTest.Errors5(1, "s1,2", Calc);
            CalcTest.Errors5(1, "12,34Ы", Calc);
            CalcTest.Errors5(1, "-1,1-", Calc);
            CalcTest.Errors5(1, ",", Calc);
            CalcTest.Errors5(1, "1,", Calc);
            CalcTest.Errors5(1, ",1", Calc);
            CalcTest.Errors5(1, "1, -", Calc);
            CalcTest.Errors5(1, "-,1", Calc);
            CalcTest.Errors5(1, "-3,+7", Calc);
            CalcTest.Errors5(1, "12.5,-13+25.00,1E-1,0", Calc);
            CalcTest.Errors5(1, "12.5,-13,+25.00,1E-1,0", Calc);
            CalcTest.Errors5(50.6, "12.5,13,+25.00,1E-1,0", Calc);
            CalcTest.Errors5(0, "0,0", Calc);
            CalcTest.Errors5(0, "-0,+0", Calc);
            CalcTest.Errors5(1, "-1 2 3 4", Calc);
            CalcTest.Errors5(10, "1 2 3 4", Calc);
            CalcTest.Errors5(1, "1,2,3,z", Calc);
            CalcTest.Errors5(1, "1,2,3,z,4", Calc);
            CalcTest.Errors5(1, "1,-1,--1", Calc);
            CalcTest.Errors5(1, "1,-1,1,1,-1", Calc);
            CalcTest.Errors5(1, "1,-1,#,1,-1", Calc);
            CalcTest.Errors5(1, "0,,,", Calc);
            CalcTest.Errors5(50.6, "12.5  13#+25.00$1E-1%0", Calc);
            CalcTest.Errors5(1, "@@#", Calc);
            CalcTest.Errors5(50.6, "12.5     13!!#+25.00&^$1E-1%%%0", Calc);
        }
    }
}