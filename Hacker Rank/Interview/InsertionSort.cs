using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class InsertionSort
	{
		public static void DoSomething()
		{
			var arr = new int[] { 4, 11, 6, 13, 10 };
			arr = Sort(arr);

		}

		private static int[] Sort(int[] arr)
		{

			//checks left and swaps until it is higher or hits left end of array
			int temp;
			for (int i = 1; i < arr.Length; i++)
			{
				for (int j = i; j > 0; j--)
				{
					if (arr[j] < arr[j - 1])
					{
						temp = arr[j];
						arr[j] = arr[j - 1];
						arr[j - 1] = temp;
					}
				}
			}

			return arr;
		}
	}
}
