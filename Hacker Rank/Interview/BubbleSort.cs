using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class BubbleSort
	{
		public static void DoSomething()
		{
			var arr = new int[] { 4, 11, 6, 13, 10 };
			arr = Sort(arr);


		}

		//time complexitity: O(n^2) memory complexity: O(1)
		private static int[] Sort(int [] arr)
		{
			//validate if we have 0 or 1 elements
			if (arr == null)
				return null;
			if (arr.Length == 0 || arr.Length == 1)
				return arr;

			bool shouldIterate = true;

			while (shouldIterate)
			{
				shouldIterate = false;
				//iteration
				for (int i = 0; i < arr.Length; ++i)
				{
					var first = arr[i];
					if (i + 1 >= arr.Length)
						continue;
					var second = arr[i + 1];

					//if we swap we need to iterate again, if we never swap then we can assume the array is sorted and return;
					if (first > second)
					{
						var temp = first;
						arr[i] = arr[i + 1];
						arr[i + 1] = temp;
						shouldIterate = true;
					}
				}
			}


			return arr;
		}
	}
}
