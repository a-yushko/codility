using System;
using Assesment.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class HasRouteTest
    {
        [TestMethod]
        public void HasRouteTestCase1()
        {
            Graph graph = GetTestCase1();
            Assert.IsTrue(graph.HasRoute(graph.Nodes[0], graph.Nodes[4]));
            Assert.IsFalse(graph.HasRoute(graph.Nodes[3], graph.Nodes[1]));
            Assert.IsFalse(graph.HasRoute(graph.Nodes[4], graph.Nodes[1]));
        }

        private Graph GetTestCase1()
        {
            Graph graph = new Graph();
            var n1 = new Node(1);
            var n2 = new Node(2);
            var n3 = new Node(3);
            var n4 = new Node(4);
            var n5 = new Node(5);

            n1.AddAdjacent(n2);
            n1.AddAdjacent(n3);
            n2.AddAdjacent(n4);
            n4.AddAdjacent(n5);
            n5.AddAdjacent(n4);

            graph.AddNode(n1);
            graph.AddNode(n2);
            graph.AddNode(n3);
            graph.AddNode(n4);
            graph.AddNode(n5);

            return graph;
        }
    }
}
