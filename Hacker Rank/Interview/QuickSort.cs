using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class QuickSort
	{
		public static void Dosomething()
		{
			int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };

			var result = Sort(arr, 0, arr.Length -1);
		}


		private static int[] Sort(int[] arr, int left, int right)
		{
			int pivot;
			if (left < right)
			{
				pivot = Partition(arr, left, right);
				if (pivot > 1)
				{
					Sort(arr, left, pivot - 1);
				}
				if (pivot + 1 < right)
				{
					Sort(arr, pivot + 1, right);
				}
			}


			return arr;
		}
		static public int Partition(int[] arr, int left, int right)
		{
			int pivot;
			pivot = arr[left];
			while (true)
			{
				while (arr[left] < pivot)
				{
					left++;
				}
				while (arr[right] > pivot)
				{
					right--;
				}
				if (left < right)
				{
					int temp = arr[right];
					arr[right] = arr[left];
					arr[left] = temp;
				}
				else
				{
					return right;
				}
			}
		}

	}
}
