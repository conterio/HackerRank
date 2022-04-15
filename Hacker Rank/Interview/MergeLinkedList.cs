using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class MergeLinkedList
	{
		public static void DoSomething()
		{
			LinkedList<int> first = new LinkedList<int>(new List<int> { 1, 12, 23, 36 });
			LinkedList<int> second = new LinkedList<int>(new List<int> { 5, 17, 28, 49 });


			var list = first.First.List;

			var ans = MergeLinkLists(first.First, second.First);


		}

		//time O(max(first,second)) O(n), space O(max(first,second))
		private static LinkedListNode<int> MergeLinkLists(LinkedListNode<int> first, LinkedListNode<int> second)
		{
			LinkedList<int> container = new LinkedList<int>();

			//validation
			if (first == null)
			{
				return second;
			}
			else if (second == null)
			{
				return first;
			}

			//compare values in each node until one is empty
			//add value to result

			while (first != null && second != null)
			{
				if (first.Value < second.Value)
				{
					container.AddLast(new LinkedListNode<int>(first.Value));
					first = first.Next;
				}
				else
				{
					container.AddLast(new LinkedListNode<int>(second.Value));
					second = second.Next;
				}
			}

			//add the remaining items in the linked list that still has items
			if ( first == null)
			{
				while (second != null)
				{
					container.AddLast(new LinkedListNode<int>(second.Value));
					//new LinkedListNode<int>(second.Value).Next = second; if this wasn't readonly we could do this and save on time plexity O(min(first,second))
					//also wouldn't need a while loop
					second = second.Next;
				}
			}
			else
			{
				while (first != null)
				{
					container.AddLast(new LinkedListNode<int>(first.Value));
					first = first.Next;
				}
			}

			return container.First;
		}

		private static LinkedListNode<int> MergeLists(LinkedListNode<int> first, LinkedListNode<int> second)
		{
			var list1 = first.List;
			var list2 = second.List;

			List<int> sortedList = new List<int>(list1);
			sortedList.AddRange(list2);
			
			// time complexity O(n) linq uses quick sort
			sortedList.Sort();

			//space complexity O(2n)
			var result = new LinkedList<int>(sortedList);

			return result.First;
		}

	}
}
