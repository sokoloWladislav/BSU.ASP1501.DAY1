using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTests
{
    [TestClass]
    public class Test_SortClass
    {
        [TestMethod]
        public void Test_SortBySumIncr()
        {
            double[][] array = new double[4][];
            array[0] = new double[4] {14, -5, 3, 1};
            array[1] = new double[3] {15, 5, 1};
            array[2] = new double[3] {42, 4, -8};
            array[3] = new double[5] {4, 11, -2, 0, -1};

            double[][] expected = new double[4][];
            expected[0] = new double[5] { 4, 11, -2, 0, -1 };
            expected[1] = new double[4] { 14, -5, 3, 1 };
            expected[2] = new double[3] { 15, 5, 1 };
            expected[3] = array[2] = new double[3] { 42, 4, -8 };

            SortClass.SortBySumIncr(array);
            CollectionAssert.AreEqual(expected[0], array[0]);
            CollectionAssert.AreEqual(expected[1], array[1]);
            CollectionAssert.AreEqual(expected[2], array[2]);
            CollectionAssert.AreEqual(expected[3], array[3]);
        }
    }
}
