using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Misc
{
	//local cache implementation
	public class LeastRecentlyUsedCache
	{
		private Dictionary<string, Node> map;
		private int capacity;

		private Node head = null;
		private Node tail = null;

		public LeastRecentlyUsedCache(int capacity)
		{
			this.map = new Dictionary<string, Node>();
			this.capacity = capacity;
		}

		public string Get(string key)
		{
			map.TryGetValue(key, out Node node);

			if (node == null)
			{
				return null;
			}

			DeleteFromList(node);
			SetListHead(node);

			return node.GetValue(); ;
		}

		public void Put(string key, string value)
		{
			map.TryGetValue(key, out Node node);

			//exists - update value
			if (node != null)
			{
				node.SetValue(value);
				DeleteFromList(node);
				SetListHead(node);
			}
			else
			{
				if (map.Count >= capacity)
				{
					map.Remove(tail.GetKey());
					DeleteFromList(tail);
				}

				Node newNode = new Node(key, value);
				map.Add(key, newNode);
				SetListHead(newNode);
			}
		}

		private void SetListHead(Node node)
		{
			if (head == null)
			{
				head = node;
				tail = node;
			}
			else
			{
				node.next = head;
				head.prev = node;

				head = node;
			}
			
		}

		private void DeleteFromList(Node node)
		{
			//if current node is only node (head & tail)
			if (node.prev == null && node.next == null)
			{
				head = node;
				tail = node;
			}
			//if current node is head
			else if (node.prev == null)
			{
				node.next.prev = null;
			}
			//if current node is tail
			else if (node.next == null)
			{
				tail = node.prev;
				node.prev.next = null;
			}
			//if current node is inbetween
			else if (node.prev != null & node.next != null)
			{
				var temp = node.prev;
				node.prev.next = node.next;
				node.next.prev = temp;
			}
		}

	}


	public class Node
	{
		private string key;
		private string value;

		public Node prev;
		public Node next;

		public Node(string key, string value)
		{
			this.key = key;
			this.value = value;
		}

		public string GetKey()
		{
			return key;
		}

		public string GetValue()
		{
			return value;
		}

		public void SetValue(string value)
		{
			this.value = value;
		}




	}
}
