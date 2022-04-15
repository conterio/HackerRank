using Stacks_and_Queues.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class LevelOrderTraversalOfBinaryTree
	{
		public static void DoSomething()
		{

			LevelOrderTraversal();

		}



		private static void LevelOrderTraversal()
		{
			var tree = new BinaryTree();

			tree.Add(100);
			tree.Add(50);
			tree.Add(200);
			tree.Add(25);
			tree.Add(75);
			tree.Add(350);
			tree.Add(10);
			tree.Add(15);
			tree.Add(200);
			tree.Add(60);


			int searchValue = 60;
			var result = tree.DoesExistDFS(searchValue);

			tree.PrintTrueUsingBFS(tree.Root);
			var node = tree.Find(15);
			node.Data = 5;
			tree.PrintTrueUsingBFS(tree.Root);

			result = tree.IsBST(tree.Root);


			
			//tree.DFS(tree.Root);
			//Console.WriteLine();

			//tree.TraverseInOrder(tree.Root);
			//Console.WriteLine();
			//result = tree.TraversePreOrder(tree.Root, 60);
			//Console.WriteLine();
			//tree.TraversePostOrder(tree.Root);

		}
	}
}
