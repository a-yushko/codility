using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assesment.Sort;

namespace Tests
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void QuickSortTest1()
        {
            int[] array = new int[7] { 4, 8, 2, 0, 1, 7, 9 };
            QuickSort.Sort(ref array);
            var expected = new int[7] { 0, 1, 2, 4, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSortTest2()
        {
            int[] array = new int[6] { 4, 8, 2, 0, 1, 2 };
            QuickSort.Sort(ref array);
            var expected = new int[6] { 0, 1, 2, 2, 4, 8 };
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSortTest3()
        {
            int[] array = new int[6] { 4, 4, 4, 4, 4, 4 };
            QuickSort.Sort(ref array);
            var expected = new int[6] { 4, 4, 4, 4, 4, 4 };
            CollectionAssert.AreEqual(expected, array);
        }
    }
}
