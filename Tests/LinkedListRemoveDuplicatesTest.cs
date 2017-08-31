using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assesment.LinkedList;

namespace Tests
{
    [TestClass]
    public class LinkedListRemoveDuplicatesTest
    {
        [TestMethod]
        public void TestRemoveDuplicates1()
        {
            // 0 -> 6 -> 0 -> 5 -> 5 -> 9
            Node n6 = new Node(9);
            Node n5 = new Node(5, n6);
            Node n4 = new Node(5, n5);
            Node n3 = new Node(0, n4);
            Node n2 = new Node(6, n3);
            Node n1 = new Node(0, n2);

            LinkedList list = new LinkedList(n1);
            list.RemoveDuplicates();

            Assert.AreEqual(4, list.Count);

            Assert.IsTrue(list.Contains(n1));
            Assert.IsTrue(list.Contains(n2));
            Assert.IsTrue(list.Contains(n4));
            Assert.IsTrue(list.Contains(n6));

            list.RemoveDuplicates();
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void TestRemoveDuplicates2()
        {
            // 5 -> 9 -> 5 -> 9
            Node n4 = new Node(9);
            Node n3 = new Node(5, n4);
            Node n2 = new Node(9, n3);
            Node n1 = new Node(5, n2);

            LinkedList list = new LinkedList(n1);
            list.RemoveDuplicates();

            Assert.AreEqual(2, list.Count);

            Assert.IsTrue(list.Contains(n1));
            Assert.IsTrue(list.Contains(n2));
        }

        [TestMethod]
        public void TestRemoveDuplicates3()
        {
            // 5 -> 5 -> 5
            Node n3 = new Node(5);
            Node n2 = new Node(5, n3);
            Node n1 = new Node(5, n2);

            LinkedList list = new LinkedList(n1);
            list.RemoveDuplicates();

            Assert.AreEqual(1, list.Count);
            Assert.IsTrue(list.Contains(n1));
        }
    }
}
