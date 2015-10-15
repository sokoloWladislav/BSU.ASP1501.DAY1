using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTests
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void TestMethodNewton()
        {
            Solver solver = new Solver();
            double power = 3;
            double num = 27;
            double fault = 0.1;

            double actual = solver.MethodNewton(num, power, fault);
            double expected = Math.Pow(actual, power);

            Assert.AreEqual(num, expected, 0.1);

            num = -27;

            actual = solver.MethodNewton(num, power, fault);
            expected = Math.Pow(actual, power);

            Assert.AreEqual(num, expected, 0.1);

            actual = solver.MethodNewton(1, 4, fault);

            Assert.AreEqual(1, actual, fault);

            power = 0;

            Assert.AreEqual(1, solver.MethodNewton(num, power, fault));

            power = 2;

            actual = solver.MethodNewton(num, 2, fault);
            Assert.IsTrue(Double.IsNaN(actual));
        }

    }
}
