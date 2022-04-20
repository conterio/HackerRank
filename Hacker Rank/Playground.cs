using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Stacks_and_Queues
{
	public static class Playground
	{

		public static void DoSomething()
		{
			var result = Fib(100);

		}

		//O(n) memory complexity O(3*64bits)
		private static ulong Fib(ulong n)
		{
			Dictionary<ulong, ulong> cache = new Dictionary<ulong, ulong>();

			cache[0] = 0;
			cache[1] = 1;
			cache[2] = 1;

			//[0]=0 = 1
			//[1]=1 = 2
			//[2]=1
			int count = 1;
			while ((ulong)count < n)
			{
				++count;
				//cache[(ulong)cache.Count] = cache[(ulong)cache.Count - 1] + cache[(ulong)cache.Count - 2];

				cache[2] = cache[0] + cache[1];
				cache[0] = cache[1];
				cache[1] = cache[2];
			}
			//if (n == 0)
			//	return 0;
			//else if (n == 1)
			//	return 1;
			//else
			//	return Fib(n - 1) + Fib(n - 2);

			return cache[2];
		}







		private static void ReverseWords()
		{
			string input = "Hello World";

			var split = input.Split(" ");


			string result = "";
			foreach (var str in split.Reverse())
			{
				result += str + " ";
			}

			result = result.Trim();
		}

		static LinkedList<int> MergeLinkedList()
		{
			//input
			LinkedList<int> head1 = new LinkedList<int>(new[] { 4, 8, 15, 19 });
			LinkedList<int> head2 = new LinkedList<int>(new[] { 7, 9, 10, 16 });
			

			//if null
			if (head1 == null)
				return head2;
			else if (head2 == null)
				return head1;

			var head = head1.First;


			//space complexitity O(2n)
			var first = new List<int>(head1);
			first.AddRange(new List<int>(head2));
			//time complexity O(n)
			return new LinkedList<int>(first.OrderBy(x => x));

		}

		static void SumOf2Numbers()
		{
			//do any 2 of these numbers add up to target
			//input
			int[] input = new int[] { 5, 7, 1, 2, 8, 4, 3 };
			int target = 10;

			//answer
			Dictionary<int, int> result = new();

			for (int i = 0; i < input.Length; i++)
			{
				var first = input[i];//5
				var second = target - first;//10-5 = 5

				if(result.TryGetValue(second, out int value))
				{
					var ans = new[] { first, second };
				}

				result[first] = i;
			}
		}

		static void MissingNumber()
		{
			//O(n) memory O(1)
			int[] input = new int[] { 3, 7, 1, 2, 8, 4, 5 };


			var sum = input.Sum();//O(n)
			var n = input.Length + 1;

			int actualSum = 0;
			for (int i = 1; i < n + 1; i++)
			{
				actualSum += i;
			}

			var act = (n * (n + 1)) / 2;

			var ans = act - sum;
		}


	}
}



//I want to see what index has the most items biggest to the right

//int[] arr = new int[] {1,2,3,4,5,0,9,8,7,6 };
//Stack<int> stack = new Stack<int>();
//int[] counts = new int[arr.Length];
//stack.Push(1);


//for (int i = 0; i < arr.Length; i++)
//{
//	int currentCount = 0;

//	while (stack.Count > 0)
//	{
//		if (arr[i] < arr[stack.Peek()])
//		{
//			++currentCount;
//			//stack.p
//		}
//	}

//}

/* stack playground
 * //go forward until I hit something lower
			int[] arr = new int[] { 6, 3, 1, 2, 5, 4, 0 };
			int[] dis = new int[arr.Length];
			Stack<int> stack = new Stack<int>();

			//1 1 4 3 1 1 0

			for (int index = arr.Length - 1; index >= 0;  index--)
			{
				while (stack.Count > 0 && arr[stack.Peek()] > arr[index])
				{
					stack.Pop();
				}

				if (stack.Count > 0)
				{
					dis[index] = stack.Peek();
				}


				stack.Push(index);
			}

			for (int i = 0; i < dis.Length; i++)
			{
				dis[i] = dis[i] - i;
			}
*/