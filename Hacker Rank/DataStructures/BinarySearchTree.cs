using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.DataStructures
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }

        public void PrintTrueUsingBFS(Node root)
		{
            string result = "";
            Queue<Node> queue = new Queue<Node>();
            int currentDepth = 0;
            root.Depth = 0;
            queue.Enqueue(root);

            while (queue.Count > 0)
			{
                var node = queue.Dequeue();

                if (node.Depth != currentDepth)
				{
                    Console.WriteLine(result);
                    result = "";
                    currentDepth = node.Depth;
				}
                if (node.IsRight)
                    result += $" R{node.Data}";
                else
                    result += $"L{node.Data} ";


                if (node.LeftNode != null)
                {
                    node.LeftNode.Depth = node.Depth + 1;
                    queue.Enqueue(node.LeftNode);
                }
                if (node.RightNode != null)
                {
                    node.RightNode.Depth = node.Depth + 1;
                    node.RightNode.IsRight = true;
                    queue.Enqueue(node.RightNode);
                }
			}

            Console.WriteLine(result);
		}

        public bool DoesExistDFS(int value)
		{
            Stack<Node> stack = new Stack<Node>();
            HashSet<int> visited = new HashSet<int>();

            stack.Push(this.Root);

            while (stack.Count > 0)
			{
                var node = stack.Peek();

                if (node.Data == value)
				{
                    return true;
				}

                if (visited.Contains(node.Data))
				{
                    stack.Pop();
				}
				else
				{
                    visited.Add(node.Data);

                    if (node.RightNode != null && !visited.Contains(node.RightNode.Data))
					{
                        stack.Push(node.RightNode);
					}
                    if (node.LeftNode != null && !visited.Contains(node.LeftNode.Data))
					{
                        stack.Push(node.LeftNode);
					}
				}
			}


            return false;
		}


        //returns true if value exists in the tree using BFS
        public bool DoesExist(int value)
		{
            //bfs
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(this.Root);

            while (queue.Count > 0)
			{
                var node = queue.Dequeue();

                if (node.Data == value)
				{
                    return true;
				}

                if (node.LeftNode != null)
				{
                    queue.Enqueue(node.LeftNode);
				}
                if (node.RightNode != null)
				{
                    queue.Enqueue(node.RightNode);
				}
			}

            return false;
		}



        public void DFS(Node root)
		{

            Stack<Node> stack = new Stack<Node>();
            HashSet<int> visited = new HashSet<int>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Peek();

                if (visited.Contains(node.Data))
                {
                    stack.Pop();
                }
                else
                {
                    visited.Add(node.Data);
                    Console.Write($"{node.Data} ");
                }

                if (node.RightNode != null && !visited.Contains(node.RightNode.Data))
                {
                    stack.Push(node.RightNode); 
                }
                if (node.LeftNode != null && !visited.Contains(node.LeftNode.Data)) 
                {
                    stack.Push(node.LeftNode);
                }

			}
        }

        public bool TraversePreOrder(Node parent, int value)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                if (parent.Data == value)
                    return true;
                var result = TraversePreOrder(parent.LeftNode, value);
                if (result)
                    return result;
                return TraversePreOrder(parent.RightNode, value);
            }
            return false;
        }


        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }


        //time O(n) traverse each node once worst case senarnio space complexity O(n)
        public bool IsBST(Node node)
		{
            //validation
            if (node == null)
			{
                return false;
			}

            //check children
            if (node.LeftNode != null)
			{
                if (node.LeftNode.Data > node.Data)
				{
                    return false;
                }
                //repeat
                 return IsBST(node.LeftNode);
			}
            if (node.RightNode != null)
			{
                if (node.RightNode.Data < node.Data)
				{
                    return false;
                }
                //repeat
                return IsBST(node.RightNode);
			}

            return true;
		}




        public bool FindAssumingBST(int value)
		{
            Node node = this.Root;

            while (node != null)
			{
                if (node.Data < value)
				{
                    node = node.LeftNode;
				}
				else if (node.Data > value)
				{
                    node = node.RightNode;
				}
                else
				{
                    return true;
				}
			}

            return false;
		}
















        public class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public int Data { get; set; }
            public int Depth { get; set; }
            public bool IsRight { get; set; } = false;
        }



    }
}
