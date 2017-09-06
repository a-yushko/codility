using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assesment.BitManipulation;

namespace Tests
{
    [TestClass]
    public class SequenceOfOnesTest
    {
        [TestMethod]
        public void TestSequenceTestCase1()
        {
            Assert.AreEqual(8, SequenceOfOnes.CountSequence(1775));
            Assert.AreEqual(6, SequenceOfOnes.CountSequence(1773));
            Assert.AreEqual(11, SequenceOfOnes.CountSequence(2047));
            Assert.AreEqual(1, SequenceOfOnes.CountSequence(0));
        }
    }
}
