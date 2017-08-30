using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.Graph
{
    public class Graph
    {
        public List<Node> Nodes { get; }
        public Graph()
        {
            Nodes = new List<Node>();
        }

        public void AddNode(Node node)
        {
            Nodes.Add(node);
        }

        /// <summary>
        /// Given a directed graph, find out whether there is a route between two nodes
        /// </summary>
        /// <param name="n1">The first node</param>
        /// <param name="n2">The second node</param>
        /// <returns></returns>
        public bool HasRoute(Node n1, Node n2)
        {
            bool hasRoute = false;
            Queue<Node> q = new Queue<Node>();
            n1.Visited = true;
            q.Enqueue(n1);
            while(q.Count > 0)
            {
                var node = q.Dequeue();
                hasRoute = Visit(node, n2);
                if (hasRoute)
                    break;
                foreach(var adjNode in node.Adjacent)
                {
                    if (!adjNode.Visited)
                    {
                        adjNode.Visited = true;
                        q.Enqueue(adjNode);
                    }
                }
            }
            return hasRoute;
        }

        private bool Visit(Node n1, Node n2)
        {
            return n1.Id == n2.Id;
        }
    }

    public class Node
    {
        public int Id { get; set; }
        public List<Node> Adjacent { get; set; }
        public bool Visited { get; set; }

        public Node(int id)
        {
            Id = id;
            Adjacent = new List<Node>();
        }

        public void AddAdjacent(Node node)
        {
            Adjacent.Add(node);
        }
    }
}
