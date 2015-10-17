using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTests
{
    [TestClass]
    public class SolverTest
    {
        #region Test Newton's Method
        [TestMethod]
        public void Test_MethodNewton_PositiveNumbers()
        {
            double power = 3;
            double num = 27;
            double fault = 0.1;

            double actual = Solver.MethodNewton(num, power, fault);
            double expected = Math.Pow(actual, power);

            Assert.AreEqual(expected, num, 0.1);
        }

        [TestMethod]
        public void Test_MethodNewton_NegativeNumbers()
        {
            double power = 3;
            double num = -27;
            double fault = 0.1;

            double actual = Solver.MethodNewton(num, power, fault);
            double expected = Math.Pow(actual, power);

            Assert.AreEqual(expected, num, 0.1);
        }

        [TestMethod]
        public void Test_MethodNewton_Power0Returned1()
        {
            double power = 0;
            double num = 4;
            double fault = 0.1;

            double actual = Solver.MethodNewton(num, power, fault);
            double expected = 1;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestMethod]
        public void Test_MethodNewton_Num1Returned1()
        {
            double power = 4;
            double num = 1;
            double fault = 0.1;

            double actual = Solver.MethodNewton(num, power, fault);
            double expected = 1;

            Assert.AreEqual(expected, num, 0.1);
        }

        [TestMethod]
        public void Test_MethodNewton_NegativeNumPower2ReturnedNaN()
        {
            double power = 2;
            double num = -27;
            double fault = 0.1;

            double actual = Solver.MethodNewton(num, power, fault);

            Assert.IsTrue(Double.IsNaN(actual));
        } 
        #endregion

        #region Test Euclide's Method
        [TestMethod]
        public void Test_EuclideMethod_PositiveNums()
        {
            int a = 8;
            int b = 12;
            int expected = 4;

            int actual = Solver.EuclideMethod(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_EuclideMethod_NegativeNums()
        {
            int a = -8;
            int b = -12;
            int expected = 4;

            int actual = Solver.EuclideMethod(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_EuclideMethod_Argument0ReturnedAnotherArg()
        {
            int a = 0;
            int b = 13;
            int expected = 13;

            int actual = Solver.EuclideMethod(a, b);

            Assert.AreEqual(expected, actual);
        }

        public void Test_EuclideMethod_3ArgsPositiveNums()
        {
            int a = 8;
            int b = 12;
            int c = 44;
            int expected = 4;

            int actual = Solver.EuclideMethod(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_EuclideMethod_3ArgsNegativeNums()
        {
            int a = -8;
            int b = -12;
            int c = -44;
            int expected = 4;

            int actual = Solver.EuclideMethod(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_EuclideMethod_Two0ReturnedAnotherArg()
        {
            int a = 0;
            int b = 13;
            int c = 0;
            int expected = 13;

            int actual = Solver.EuclideMethod(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        public void Test_EuclideMethod_4ArgsPositiveNums()
        {
            int a = 8;
            int b = 12;
            int c = 44;
            int d = 20;
            int expected = 4;

            int actual = Solver.EuclideMethod(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_EuclideMethod_4ArgsNegativeNums()
        {
            int a = -8;
            int b = -12;
            int c = -44;
            int d = -20;
            int expected = 4;

            int actual = Solver.EuclideMethod(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_EuclideMethod_Three0ReturnedAnotherArg()
        {
            int a = 0;
            int b = 13;
            int c = 0;
            int d = 0;
            int expected = 13;

            int actual = Solver.EuclideMethod(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_EuclideMethod_GetTime()
        {

            int a = 8;
            int b = 12;
            int c = 44;
            int d = -16;
            long time = 0;

            int actual = Solver.EuclideMethod(out time, a, b);
            System.Diagnostics.Debug.WriteLine(time + " 1");

            actual = Solver.EuclideMethod(out time, a, b, c);
            System.Diagnostics.Debug.WriteLine(time + " 2");

            actual = Solver.EuclideMethod(out time, a, b, c, d);
            System.Diagnostics.Debug.WriteLine(time + " 3");
        }
        #endregion

        #region Test Stein's Method

        [TestMethod]
        public void Test_SteinMethod_PositiveNums()
        {
            int a = 8;
            int b = 12;
            int expected = 4;

            int actual = Solver.SteinMethod(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SteinMethod_NegativeNums()
        {
            int a = -8;
            int b = -12;
            int expected = 4;

            int actual = Solver.SteinMethod(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SteinMethod_Argument0ReturnedAnotherArg()
        {
            int a = 0;
            int b = 13;
            int expected = 13;

            int actual = Solver.SteinMethod(a, b);

            Assert.AreEqual(expected, actual);
        }

        public void Test_SteinMethod_3ArgsPositiveNums()
        {
            int a = 8;
            int b = 12;
            int c = 44;
            int expected = 4;

            int actual = Solver.SteinMethod(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SteinMethod_3ArgsNegativeNums()
        {
            int a = -8;
            int b = -12;
            int c = -44;
            int expected = 4;

            int actual = Solver.SteinMethod(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SteinMethod_Two0ReturnedAnotherArg()
        {
            int a = 0;
            int b = 13;
            int c = 0;
            int expected = 13;

            int actual = Solver.SteinMethod(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        public void Test_SteinMethod_4ArgsPositiveNums()
        {
            int a = 8;
            int b = 12;
            int c = 44;
            int d = 20;
            int expected = 4;

            int actual = Solver.SteinMethod(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SteinMethod_4ArgsNegativeNums()
        {
            int a = -8;
            int b = -12;
            int c = -44;
            int d = -20;
            int expected = 4;

            int actual = Solver.SteinMethod(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SteinMethod_Three0ReturnedAnotherArg()
        {
            int a = 0;
            int b = 13;
            int c = 0;
            int d = 0;
            int expected = 13;

            int actual = Solver.SteinMethod(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SteinMethod_GetTime()
        {

            int a = 8;
            int b = 12;
            int c = 44;
            int d = -16;
            long time = 0;

            int actual = Solver.SteinMethod(out time, a, b);
            System.Diagnostics.Debug.WriteLine(time + " 1");

            actual = Solver.SteinMethod(out time, a, b, c);
            System.Diagnostics.Debug.WriteLine(time + " 2");

            actual = Solver.SteinMethod(out time, a, b, c, d);
            System.Diagnostics.Debug.WriteLine(time + " 3");
        } 

        #endregion
    }
}
