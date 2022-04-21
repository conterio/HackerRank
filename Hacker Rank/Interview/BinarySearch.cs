using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class BinarySearch
	{
		public static void DoSomething()
		{
			var result = BS(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 7);
		}


		private static int BS(int [] arr, int search)
		{
			if (arr.Length == 0)
				return -1;

			int mid = arr.Length / 2;

			if (arr[mid] == search)
				return mid;
			else if (arr[mid] < search)
			{
				return mid + BS(arr.Skip(mid).Take(arr.Length - mid).ToArray(), search);
			}
			else
			{
				return BS(arr.Take(mid).ToArray(), search);
			}
		}
	}
}
