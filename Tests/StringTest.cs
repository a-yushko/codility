using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assesment.Strings;

namespace Tests
{
    /// <summary>
    /// Summary description for StringTest
    /// </summary>
    [TestClass]
    public class StringTest
    {

        [TestMethod]
        public void TestAllUnique()
        {
            Assert.IsTrue(StringTask.AllUnique("throne"));
            Assert.IsFalse(StringTask.AllUnique("character"));
            Assert.IsTrue(StringTask.AllUnique(""));
        }

        [TestMethod]
        public void TestAllUniqueCaseInsensitive()
        {
            Assert.IsFalse(StringTask.AllUnique("Stwopqadfs"));
            Assert.IsFalse(StringTask.AllUnique("MOM"));
        }

        [TestMethod]
        public void TestAllUnique2()
        {
            Assert.IsTrue(StringTask.AllUnique2("throne"));
            Assert.IsFalse(StringTask.AllUnique2("character"));
            Assert.IsTrue(StringTask.AllUnique2(""));
        }

        [TestMethod]
        public void TestAllUnique2CaseInsensitive()
        {
            Assert.IsFalse(StringTask.AllUnique2("Stwopqadfs"));
            Assert.IsFalse(StringTask.AllUnique2("ARR"));
            Assert.IsFalse(StringTask.AllUnique2("aRtiFACT"));
            Assert.IsTrue(StringTask.AllUnique2("aSTro"));
        }

        [TestMethod]
        public void TestAllUnique3()
        {
            Assert.IsTrue(StringTask.AllUnique3("throne"));
            Assert.IsFalse(StringTask.AllUnique3("character"));
            Assert.IsTrue(StringTask.AllUnique3(""));
        }

        [TestMethod]
        public void TestAllUnique3CaseInsensitive()
        {
            Assert.IsFalse(StringTask.AllUnique3("Stwopqadfs"));
            Assert.IsFalse(StringTask.AllUnique3("ARR"));
            Assert.IsFalse(StringTask.AllUnique3("aRtiFACT"));
            Assert.IsTrue(StringTask.AllUnique3("aSTro"));
        }
    }
}
