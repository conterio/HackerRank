using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class CloneDirectedGraph
	{
		public static void DoSomething()
		{
			
		}


		private static Node clone(Node root)
		{
			Dictionary<Node, Node> nodes_completed = new Dictionary<Node, Node>();

			return CloneRecursive(root, nodes_completed);
		}

		private static Node CloneRecursive(Node root, Dictionary<Node, Node> nodesCompleted)
		{
			if (root == null)
			{
				return null;
			}

			Node pNew = new Node(root.data);
			nodesCompleted.Add(root, pNew);

			foreach (Node p in root.neighbors)
			{
				Node x = nodesCompleted[p];
				if (x == null)
				{
					pNew.neighbors.Add(CloneRecursive(p, nodesCompleted));
				}
				else
				{
					pNew.neighbors.Add(x);
				}
			}
			return pNew;
		}
	}


	class Node
	{
		public int data;
		public List<Node> neighbors = new List<Node>();
		public Node(int d) 
		{ 
			data = d; 
		}
	}
}
